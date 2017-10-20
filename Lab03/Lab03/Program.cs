using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question Two

            int number1;
            int number2;
            int sum;

            Console.Write("Enter First Integer");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Integer");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");

            //Question Three

            int x;
            int y;
            int z;
            int result;

            Console.Write("Enter First Integer");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Integer");
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Integer");
            z = int.Parse(Console.ReadLine());

            result = (x + y) * (z + 10);

            Console.WriteLine($"Product is {result}");

            //Question Four

            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("Hello\\World!");


        }
    }
}
