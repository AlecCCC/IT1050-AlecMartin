using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {

            MyMath math1 = new MyMath();
            double sum = math1.AddNumbers(10, 20);
            Console.WriteLine(sum);


            MyMath math2 = new MyMath();
            double result = math2.Multiply(10, 20);
            Console.WriteLine(result);

            MyMath math3 = new MyMath();
            double division = math3.Divide(10, 5);
            Console.WriteLine(division);

            MyMath math4 = new MyMath();
            double Subtract = math4.Divide(10, 10);
            Console.WriteLine(division);

        }
    }
} 