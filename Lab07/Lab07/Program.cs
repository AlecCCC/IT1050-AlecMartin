using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        /////////////////// Question One  /////////////////////////
        /*
        int i = 1;
         while (i < 10)
        {
            Console.WriteLine(i);
            i += 2;
        }
        // loop control var is int i = 1;
        //Counter is i  
        //loop terminating condition is (i < 10 ) because once it hits 9, 10 < 10 is not true therefore stopping there 
        // You modify the var by i ++ or something like that, this case it is i += 2;
        */

        //////////////// Question Two /////////////////////

        /*
                    for (int i = 30; i <= 45; ++i)
                    {
                        Console.WriteLine(i);
                        {
                            if ((i % 2) == 0)
                            { Console.WriteLine("Number is Even"); }
                            else if ((i % 2) != 0)
                            {
                                Console.WriteLine("Number is Odd");
                            }
                        }

                    }
                        */

        ///////////////////////   Question Three   ///////////











        ////////////////////////////  Question Four  ///////////////////////////

        /*
        int i = 10;
        while (i <= 20)
        {
            Console.WriteLine(i);
            i++;

        }
        //To Fix, I had to change 21 to 20, then i had to add the i++ so it can increase the number by one instead of looping.
        */


        ////////////////// Question Five /////////////

        /*
        for (int i = 0; i < 101; i++)
            Console.WriteLine($"{i}\n*******");
            Console.WriteLine("********");
        */


        /*

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
            int i = 0;
            int c = 0;
            for (i = 0; i < COUNTER; i++)
            {
                for (c = 0; c <= i; c++)
                    Console.Write(STAR);

                Console.WriteLine();
            }

        }

        */



    }
    }
