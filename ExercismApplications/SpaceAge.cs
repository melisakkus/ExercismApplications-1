using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismApplications
{
    public class SpaceAge
    {
        private double mySeconds;
        public SpaceAge(int seconds)
        {
            mySeconds = seconds;
        }
        public double OnEarth()
        {
            return mySeconds / 31557600;
        }
        public double OnMercury()
        {
            return OnEarth() / 0.2408467;
        }
        public double OnVenus()
        {
            return OnEarth() / 0.61519726;
        }
        public double OnMars()
        {
            return OnEarth() / 1.8808158;
        }
        public double OnJupiter()
        {
            return OnEarth() / 11.862615;
        }
        public double OnSaturn()
        {
            return OnEarth() / 29.447498;
        }
        public double OnUranus()
        {
            return OnEarth() / 84.016846;
        }
        public double OnNeptune()
        {
            return OnEarth() / 164.79132;
        }
    }
}

//Instructions
//Given an age in seconds, calculate how old someone would be on a planet in our Solar System.
//One Earth year equals 365.25 Earth days, or 31,557,600 seconds.
//If you were told someone was 1,000,000,000 seconds old, their age would be 31.69 Earth-years.
//For the other planets, you have to account for their orbital period in Earth Years:

//Planet Orbital period in Earth Years
//Mercury	0.2408467
//Venus	0.61519726
//Earth	1.0
//Mars	1.8808158
//Jupiter	11.862615
//Saturn	29.447498
//Uranus	84.016846
//Neptune	164.79132