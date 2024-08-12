using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExercismApplications.LuciansLusciousLasagna;



namespace ExercismApplications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            isLeapYear();

            //Gigasecond();

            //toCustomers();

            //ElonsToys();

            //AnnalynsInfiltrationCanFastAttack();

            //LuciansLasagna();

            Console.ReadLine();
        }


        static int year = 2024;
        private static void isLeapYear()
        {
            bool isLeapYear = ExercismApplications.Leap.IsLeapYear(year);
            Console.WriteLine($"The year {year} is leap year : {isLeapYear}");
            Console.WriteLine("The year " + year + " is leap year: " + isLeapYear);
            Console.WriteLine("The year: {0} , isLeapYear: {1} ", year, isLeapYear);
        }

        private static void Gigasecond()
        {
            var newTime = ExercismApplications.Gigasecond.Add(new DateTime(2024, 08, 09, 20, 48, 23));
            Console.WriteLine(newTime);
            Console.WriteLine(DateTime.Now);

            //DateTime nesnesi oluştururken yıl, ay, gün, saat, dakika ve saniye bilgilerini doğru bir sırayla vermeniz gerekiyor. 
        }

        private static void toCustomers()
        {
            string toCustomers = ExercismApplications.TwoFer.Speak();
            string toCustomers2 = ExercismApplications.TwoFer.Speak("Melisa");
            Console.WriteLine(toCustomers + " Thank you. And " + toCustomers2);
        }

        private static void ElonsToys()
        {
            var car = ExercismApplications.ElonsToys.RemoteControlCar.Buy();
            car.Drive();
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            car.Drive();
            Console.WriteLine(car.DistanceDisplay());
            Console.WriteLine(car.BatteryDisplay());

            Console.ReadLine();
        }

        static bool isKnightAwake = true;
        private static void AnnalynsInfiltrationCanFastAttack()
        {
            bool outcome = AnnalynsInfiltration.CanFastAttack(isKnightAwake);
            Console.WriteLine("Fast Attack Can Be Done : " + outcome);
        }

        private static void LuciansLasagna()
        {
            Lasagna lasagna = new LuciansLusciousLasagna.Lasagna();
            int time = lasagna.ElapsedTimeInMinutes(4, 2);
            Console.WriteLine("Elapsed Time : " + time);
        }
    }
}
