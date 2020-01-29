using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WaterHero: Hero
    {
        public WaterHero()
        {
            element = "water";
            elementalStrength = "fire";
            elementalWeakness = "earth";
            aviableAttacks.Add(Splash);
        }

        void Splash()
        {

        }
    }
}
