using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Console.WriteLine("Welcome to the superhero academy! Do you want to create a new super hero? (you don't have a choice)");
            Console.ReadLine();
            Console.WriteLine("Which element do want the new hero to have? You can chose between air, fire, earth and water");
            string input ="";
            while (input.ToLower() != "air" && input.ToLower() != "fire" && input.ToLower() != "earth" && input.ToLower() != "water")
            {
                input = Console.ReadLine();
            }
            if (input=="air")
            {
                hero = new AirHero();
            }
            else if (input == "fire")
            {
                hero = new FireHero();
            }
            else if (input == "earth")
            {
                hero = new EarthHero();
            }
            else if (input == "water")
            {
                hero = new WaterHero();
            }

            Console.WriteLine("What should the name of this hero be?");

            hero.Name = Console.ReadLine();

            Console.WriteLine("The hero's name is: "+hero.Name+" and their element is: "+hero.element);

            Console.ReadLine();
        }
    }
}
