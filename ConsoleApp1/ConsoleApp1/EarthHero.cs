using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EarthHero: Hero
    {
        public EarthHero()
        {
            element = "earth";
            elementalStrength = "water";
            elementalWeakness = "air";
            aviableAttacks.Add(Earthquake);
        }

        void Earthquake()
        {

        }
    }
}
