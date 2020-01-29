using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FireHero: Hero
    {
        public FireHero()
        {
            element = "fire";
            elementalStrength = "air";
            elementalWeakness = "water";
            aviableAttacks.Add(Fireworks);
        }

        void Fireworks()
        {

        }
    }
}
