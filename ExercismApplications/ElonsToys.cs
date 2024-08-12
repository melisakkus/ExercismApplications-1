using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class ElonsToys
    {
        public class RemoteControlCar
        {
            private int battery = 100;
            private int distances = 0;

            public static RemoteControlCar Buy()
            {
                return new RemoteControlCar();
            }

            public string DistanceDisplay()
            {
                return $"Driven {distances} meters";
            }

            public string BatteryDisplay()
            {
                return battery > 0 ? $"Battery at {battery}%" : $"Battery empty";
            }

            public void Drive()
            {
                if(battery == 0)
                {
                    return;
                }
                battery-- ;
                distances += 20;
            }
        }
    }
}


// This anahtar sözcüğü ilgili sınıfta o sınıftan türetilmiş nesneleri
// sınıf içinde temsil etmemizi sağlayan bir keyworddür.

//Instructions
//In this exercise you'll be playing around with a remote controlled car,
//which you've finally saved enough money for to buy.

//Cars start with full (100%) batteries. Each time you drive the car using the remote control,
//it covers 20 meters and drains one percent of the battery.

//The remote controlled car has a fancy LED display that shows two bits of information:

//The total distance it has driven, displayed as: "Driven <METERS> meters".
//The remaining battery charge, displayed as: "Battery at <PERCENTAGE>%".
//If the battery is at 0%, you can't drive the car anymore and the battery display will show "Battery empty".

//You have six tasks, each of which will work with remote controlled car instances.