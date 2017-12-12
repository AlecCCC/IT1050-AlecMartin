using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hero3PowerLevel = 50;
            int Hero2PowerLevel = 8;
            int Hero1PowerLevel = 32;
            Hero myHero = new Hero();
            Hero Hero1 = new Hero("Flash", "Zoom", "Human", "Speed", true, Hero1PowerLevel);
            Hero Hero2 = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly", Hero2PowerLevel);
            Hero Hero3 = new Hero("Zane", 30, 110, Hero3PowerLevel);
            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)  DONE
                 - Investigate  Done
                 - FightCrime (a least one must win. at least one must not win) DONE
                 - Fly (at least one superhero should be able to fly)
                 - Climb Done
            */

            // Power Charge
           for (int i = 1; i < 50; i++)              
            {
                if (i % 3 == 0)

                {
                    Hero3PowerLevel = Hero3.ChargePower();
                    Hero2PowerLevel = Hero2.ChargePower();
                    Hero1PowerLevel = Hero1.ChargePower();
                }
            }

            Hero1.Display1();
            Hero2.Display2();
            Hero3.Display3();
        }
    }
}
