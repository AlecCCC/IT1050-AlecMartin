using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int car1Speed = 20;
            int car2Speed = 0;

            Car car1 = new Car("Ford", "Focus", 2018, car1Speed);
            Car car2 = new Car("Subaru", "WRX", car2Speed);



        }
    }
}
