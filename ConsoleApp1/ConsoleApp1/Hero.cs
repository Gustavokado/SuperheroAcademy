using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Hero
    {
        static Random random = new Random();
        string name;
        int patience;
        int intelligence;
        int power;
        public string element;
        protected string elementalWeakness;
        protected string elementalStrength;
        protected delegate void attack();
        protected List<attack> aviableAttacks = new List<attack>();

        public Hero()
        {
            patience = random.Next(101);
            intelligence = random.Next(101);
            power = random.Next(101);
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

       

        public void GetAviableAttacks()
        {
            
        }
        
    }
}
