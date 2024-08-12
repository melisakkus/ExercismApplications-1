﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeekCount = new int[] { 0, 2, 5, 3, 7, 8, 4 };
            return lastWeekCount;
        }

        public int Today()
        {
            return birdsPerDay[birdsPerDay.Length - 1];
        }

        // public int Today() => birdsPerDay.Last();

        public void IncrementTodaysCount()
        {
            birdsPerDay[birdsPerDay.Length - 1]++;
        }

        public bool HasDayWithoutBirds()
        {
            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int count = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                count += birdsPerDay[i];
            }
            return count;
        }

        public int BusyDays()
        {
            int busyDays = 0;

            for (int i = 0; i < birdsPerDay.Length; i++)
            {
                if (birdsPerDay[i] >= 5)
                {
                    busyDays++;
                }
            }
            return busyDays;
        }

        // public int BusyDays() => birdsPerDay.Count(day =>  day >= 5);
        // count eleman sayısını verir
    }
}

//Instructions
//You're an avid bird watcher that keeps track of how many birds have visited your garden in the last seven days.
//You have six tasks, all dealing with the numbers of birds that visited your garden.

//1)For comparison purposes, you always keep a copy of last week's counts nearby, which were: 0, 2, 5, 3, 7, 8 and 4.
//Implement the (static) BirdCount.LastWeek() method that returns last week's counts:

//2)Implement the BirdCount.Today() method to return how many birds visited your garden today.
//The bird counts are ordered by day, with the first element being the count of the oldest day, and the last element
//being today's count.

//3)Implement the BirdCount.IncrementTodaysCount() method to increment today's count:
//4)Implement the BirdCount.HasDayWithoutBirds() method that returns true if there was a day at which zero birds
//visited the garden; otherwise, return false:
//5)Implement the BirdCount.CountForFirstDays() method that returns the number of birds that have visited your garden
//from the start of the week, but limit the count to the specified number of days from the start of the week.
//6)Some days are busier that others. A busy day is one where five or more birds have visited your garden.
//Implement the BirdCount.BusyDays() method to return the number of busy days: