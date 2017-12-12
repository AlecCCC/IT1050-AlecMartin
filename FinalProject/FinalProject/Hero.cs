using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string Nemesis;

        public Hero()
        {
        }

        public Hero(string name, string nemesis, string race, string Power, bool AntiHero, int PowerLevel)
        {
            this.Name = name;
            this.Nemesis = nemesis;
            this.Race = race;
            this.Power = Power;

        }

        public Hero(string name, string nemesis, string race, string power, int PowerLevel)
        {
            this.Name = name;
            this.Nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.PowerLevel = PowerLevel;
        }


        // TODO: Problem 1 - add a constructor method with a different number and/or types of parameters DONE?

        public Hero(string name, int age, double health, int PowerLevel)
        {
            this.Name = name;
            this.Age = age;
            this.Health = health;
            this.PowerLevel = PowerLevel;
        }

        public void FightCrime(string address)
        {
            // TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49 DONE
            if (PowerLevel > 49 ) 
            {
                Console.WriteLine("Successfully fought crime at address");
                return;
            }
        }

        private bool Investigate()

        {
            // TODO: Problem 3 - output "Investigated Crime" and return true  DONE
            bool returnValue = true;
            if(true)
            {
                Console.WriteLine("Investigated Crime");
                return returnValue;
            }

        }

        public void Fly()
        {
            // TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"  DONE
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine($"{Name} is Flying!");
                
            }

            else if (this.Power.Contains("Fly"))
            {
                Console.WriteLine($"{Name} can't fly!");
            }
        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Crafting with " + material);
        }

        public void Climb(int height)
        {
            if (height > 1)
            Console.WriteLine(this.Name + " is climbing");
        }
       
        public int ChargePower()
        {
            // TODO: Problem 5 - increase this.PowerLevel by 1

            {
                this.PowerLevel++;
                return this.PowerLevel;
            }

        }


        public void Display1()
        {
            Console.WriteLine("His name is " + Name + ".  His enemy is " + Nemesis + ".  He is known for his " + Power + ".  He is an Antihero, and his Power level is " + PowerLevel + ".");
            if (PowerLevel > 49)
            {
                Console.WriteLine("Successfully fought crime at address");
                return;
            }
            else if (PowerLevel < 49)
            {
                Console.WriteLine("Could not Fight!");
            }

            {
                Console.WriteLine("Investigated Crime");
            }

            {
                Console.WriteLine(this.Name + " is climbing");
            }

            Console.WriteLine();
        }
    


        public void Display2()
        {
            Console.WriteLine(Name + "'s  Nemesis is " + Nemesis + " and her race is " + Race + ".  After charging her power, it is at  " + PowerLevel + ".");
            if (PowerLevel > 49)
            {
                Console.WriteLine("Successfully fought crime at address");
                return;
            }
            else if (PowerLevel < 49)
            {
                Console.WriteLine("Could not Fight!");
            }
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine($"{Name} is Flying!");
            }
            {
                Console.WriteLine(this.Name + " is climbing");
            }

            {
                Console.WriteLine("Investigated Crime");
            }
            Console.WriteLine();
        }



        public void Display3()
        {
            Console.WriteLine(Name + " is " + Age + " Years old, and has " + Health + " health.  After charging his power, it is at  " + PowerLevel + ".");
            if (PowerLevel > 49)
            {
                Console.WriteLine("Successfully fought crime at address");
                return;
            }

            else if (PowerLevel < 49)
            {
                Console.WriteLine("Could not Fight!");
            }

            {
                Console.WriteLine(Name + " is climbing");
            }

            {
                Console.WriteLine("Investigated Crime");
            }

        }



        // TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value for this.PowerLevel (try to use a loop calling the other ChargePower)

    }
}
