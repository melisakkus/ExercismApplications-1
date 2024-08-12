using ExercismApplications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class RemoteControlCar
    {
        // TODO: define the constructor for the 'RemoteControlCar' class
        int _speed;
        int _batteryDrain;
        public RemoteControlCar(int speed, int batteryDrain)
        {
            _speed = speed;
            _batteryDrain = batteryDrain;
            var car = new RemoteControlCar(speed, batteryDrain);
        }

        public void Drive()
        {

        }
    }

    public class RaceTrack
    {
        int _distance;
        public RaceTrack(int distance)
        {
            _distance = distance;
            var raceTrack = new RaceTrack(distance);
        }
    }
}


//Instructions
//In this exercise you'll be organizing races between various types of remote controlled cars.
//Each car has its own speed and battery drain characteristics.
//Cars start with full (100%) batteries. Each time you drive the car using the remote control,
//it covers the car's speed in meters and decreases the remaining battery percentage by its battery drain.
//If a car's battery is below its battery drain percentage, you can't drive the car anymore.
//Each race track has its own distance. Cars are tested by checking if they can finish the track
//without running out of battery.
//You have six tasks, each of which will work with remote controller car instances.

//1)Allow creating a remote controller car by defining a constructor for the RemoteControlCar class 
//    that takes the speed of the car in meters and the battery drain percentage as its two parameters (both of type int):
//int speed = 5;
//int batteryDrain = 2;
//var car = new RemoteControlCar(speed, batteryDrain);


