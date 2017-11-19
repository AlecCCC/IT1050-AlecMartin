using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6_15_DisplayingTriangles
{
    class Program
    {
        const string STAR = "*";
        const string SPACE = " ";
        const int COUNTER = 10;

        static void Main(string[] args)
        {
            DisplayA();


            Console.ReadLine();
        }

        static public void DisplayA()
        {
            int index = 0;
            int c = 0;
            for (index = 0; index < COUNTER; index++)
            {
                for (c = 0; c <= index; c++)
                    Console.Write(STAR);

                Console.WriteLine();    //new line after each row
            }
            Console.WriteLine();    //new line after pattern
        }

        }

    }
