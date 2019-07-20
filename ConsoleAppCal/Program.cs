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
        }
    }

    interface calendar
    {
        void Log(string message);

    }
    public class scheduler : calendar
    {

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
