using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Question One's solution

            /* int i = 2;
             Boolean keepLooping = true;
                 while (keepLooping)
             {
                 if (i <= 11)

                     keepLooping = false;
                 i++;
                 Console.WriteLine(i);
                 */

            //////////////////////////////////////////////////////////////////////////////////
            //Question Two's Solution
            /*
           int i = 2;
            while (i <= 128)
            {
                Console.WriteLine(i);
                i *= 2;
            }
            */
            ////////////////////////////////////////////////////////////////////////////////
            // Question Three's Solution

            /*
            for (int i = 49; i >=1; --i)
            {
                Console.Write($"{i},");
            }
            */

            ///////////////////////////////////////////////////////////////////////////////

            //Question's Four's Solution

            /*
            int i = 1;
            while (i <= 21)
            {
                Console.Write($"{i}   ");
                i += 2;
            }
            */
            //////////////////////////////////////////////////////////////////////////////////

            // Question Five's Solution

            /* int n = 8;
             int i = 10; // initialize
            while (i > n)
             {
                 Console.WriteLine(i);
                 i++;
             }
             */

            //////////////////////////////////////////////////////////////////////////////////

            /* int n = 8;
             int i = 10; // initialize
             do
             {
                 Console.Write("*");
                 i++; // update!
             } while (i < n); // test condition  

             */

            /*The Do-while will only enter one output (the *) for as long as i is greater than N.  The while statement tests the condition at the beggining of the loop.
             if it was false it would not execute.  The do while will execute the body at least one time.  While output is spitting an infinite amount of numbers while
             the do while only outputs the */

            ///////////////////////////////////////////////////////////////////////////////


            //Question Six's solution
            /*
            bool icyRain = false;
            bool tornadoWarning = false;
            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine("Let's Go Outside!");
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////



        }


    }
}
