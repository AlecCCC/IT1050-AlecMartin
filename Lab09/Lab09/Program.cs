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

            int product = MyMath.Multiply(10, 20);
        }


    }
} 