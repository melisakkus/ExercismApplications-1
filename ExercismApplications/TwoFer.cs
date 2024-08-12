using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public static class TwoFer
    {
        public static string Speak(string name = "you")
        {
            return $"One for {name}, one for me.";
        }

    }
}


//Instructions
//Your task is to determine what you will say as you give away the extra cookie.

//If you know the person's name (e.g. if they're named Do-yun), then you will say:
//One for Do-yun, one for me.
//If you don't know the person's name, you will say you instead.
//One for you, one for me.