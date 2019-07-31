using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("hello world!");


            int somenum = 0;

            for (int i = 0; i < 10; i++)
            {
                somenum++;
                Console.WriteLine(somenum);
            }



            try
            {
                int exampleValue = 1000;
                Console.WriteLine(exampleValue);
            }
            catch(Exception)
            {
               
            }




            scheduler newsched = new scheduler();

            newsched.checkSchedule(1, 5);

            DateTime date1 = DateTime.Now;
            DateTime date2 = date1.AddDays(30);


            Console.WriteLine(date1);

            Console.WriteLine(date2);


            Console.WriteLine("hello, you may type anything to continue");
            string name = Console.ReadLine();
        }
    }

    interface calendar
    {
        void Log(string message);

    }
    public class scheduler : calendar
    {
        // DateTime date1 = new DateTime(2015, 12, 25);

        //DateTime date2 = new DateTime(2015, 12, 29);



        /*
         * TEST PRINT FOR DATETIME
         * 
         * Console.WriteLine(date1.ToString());
         * 
         */
        int start = 1;

        int end = 5;



        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        
        /*
         * sample version of rescheduling an event
         */

        public void checkSchedule(int day1, int day2)
        {
            //Console.WriteLine("-_-_-_-");
            if ((day1 >= day2) && (day1 % 5 != 0))
                    {
                        Console.WriteLine("Final DAY:" + day1);
                    }

            if(day1%5 == 0)
            {
                
                Console.WriteLine("Currernt day:" + day1);
                day1++;
                checkSchedule(day1, day2);

            }

            if(day1 < day2)
            {
                
                Console.WriteLine("Currernt day:" + day1);
                day1++;
                checkSchedule(day1, day2);
            }            

        }


        public int adder(int int1, int int2)
        {
            return int1 + int2;
        }
    }
}
