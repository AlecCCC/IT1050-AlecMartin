using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// QUESTION ONE

// The Single selection and while repetition statements are similar by performing an action if whether it is true or false.  They are different because if single is true, it will do the action once, unlike a repetition statement which will repeat the action.

// QUESTION ONE END

// QUESTION TWO

//  int speedLimit; 
//  int speed;
//  speedLimit = 35; 
//  speed = 42; 
//  if (speed > speedLimit) 
//  Console.Write( "SLOW NOW" );

//QUESTION TWO END






namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        { // QUESTION THREE!!!!! START
            int grade = 44;
            if (grade >= 60)
            {
                Console.WriteLine("Passed (It is True!)");
            }
            else
            {
                Console.WriteLine("Failed (It is False!)");
            }
            // QUESTION THREE END!!!!

            //QUESTION FOUR START
            Console.WriteLine("Input temperature in Fahrenheit: ");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int conver = ((fah - 32) / 9) * 5;
            Console.WriteLine("Temperature in Celsius is {0}: ", conver);

            if (conver >= 90)
            {
                Console.WriteLine("it is hot");
            }

            if (conver <= 40)
            {
                Console.WriteLine("it is cold");
            }
            // QUESTION FOUR END!!!!


            // QUESTION FIVE

            int i = 1;
            while (i < 11)
            {
                Console.Write("While Output:");
                Console.WriteLine(i);
                i++;
            }
            //QUESTION FIVE END

            //QUESTION SIX START

            int j = 60;

            while (j >= 20)
            {
                Console.Write("while Output: ");
                Console.WriteLine(j);
                j--;
            }
            //QUESTION SIX END

            // QUESTION SEVEN START
            int k = 10;
            while (k <= 20)
            {
                Console.Write("While Output: ");
                Console.WriteLine(k);
                k++;
            }
            // QUESTION SEVEN END


        }
    }
}
