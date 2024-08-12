using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public static class Leap
    {
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && !(year % 100 == 0)) ||
              (year % 4 == 0 && year % 100 == 0 && year % 400 == 0))
            {
                return true;
            }
            return false;
        }
        /*       if(year%4==0)
               {
                   if(!(year%100==0))
                   {
                       return true;
                   }
                   else if(year%400==0)
                   {
                       return true;
                   }
               }
               return false;

           }
       */
    }
}
