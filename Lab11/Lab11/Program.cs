using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION ONE

            /*

            string[] names = new string[5];
            names[0] = "Al Dente";
            names[1] = "Anna Graham";
            names[2] = "Earle Bird";
            names[3] = "Ginger Rayle";
            names[4] = "Iona Ford";

            Console.WriteLine(names [2]);
            Console.WriteLine(names[4]);

             */



            //////  Question Two  //////

            /*

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            for (int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i] + ", " + i);
            }

                */


            // Question Three

            /*

            string[] season = new string[4];

            season[0] = "Spring";
            season[1] = "Summer";
            season[2] = "Fall";
            season[3] = "Winter";

            for (int i = 0; i < season.Length; i++)
            {
                Console.WriteLine(season[i]);
            }

    */


            //Question Four



            int[] number = new int[1000];
            Random random = new Random();
            int randomNumber = random.Next();
            for (int i = 0; i < 1000; i++)
            {
                randomNumber = random.Next(0, 100);
                Console.Write(randomNumber + ", ");

            }

            foreach (int i in number)
            {
                Console.WriteLine(i.ToString());
            }





        }
    }
}
