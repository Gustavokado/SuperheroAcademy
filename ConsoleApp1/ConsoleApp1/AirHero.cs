using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AirHero: Hero
    {
        public AirHero()
        {
            element = "air";
            elementalStrength = "earth";
            elementalWeakness = "fire";
            aviableAttacks.Add(AirBlast);
        }

        void AirBlast()
        {

        }
    }
}
