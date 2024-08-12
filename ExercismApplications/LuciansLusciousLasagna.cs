using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class LuciansLusciousLasagna
    {
        public class Lasagna
        {
            public int ExpectedMinutesInOven()
            {
                return 40;
            }

            public int RemainingMinutesInOven(int actualMinutes)
            {
                return ExpectedMinutesInOven() - actualMinutes;
            }

            public int PreparationTimeInMinutes(int layers)
            {
                return layers * 2;
            }

            public int ElapsedTimeInMinutes(int layers, int actualMinutes)
            {
                return PreparationTimeInMinutes(layers) + actualMinutes;

            }
        }
    }
}


//1)Define the Lasagna.ExpectedMinutesInOven() method that does not take any parameters and 
//returns how many minutes the lasagna should be in the oven. According to the cooking book,
//the expected oven time in minutes is 40  

//2)Define the Lasagna.RemainingMinutesInOven() method that takes the actual minutes the lasagna
//has been in the oven as a parameter and returns how many minutes the lasagna still has to remain in the oven,
//based on the expected oven time in minutes from the previous task

//3)Define the Lasagna.PreparationTimeInMinutes() method that takes the number of layers you
//added to the lasagna as a parameter and returns how many minutes you spent preparing the lasagna,
//assuming each layer takes you 2 minutes to prepare.

//4)Define the Lasagna.ElapsedTimeInMinutes() method that takes two parameters: the first parameter is the
//number of layers you added to the lasagna, and the second parameter is the number of minutes the lasagna
//has been in the oven. The function should return how many minutes you've worked on cooking the lasagna,
//which is the sum of the preparation time in minutes, and the time in minutes the lasagna has spent in the
//oven at the moment.
