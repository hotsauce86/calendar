using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCal
{
    class Program
    {
        static List<DateTime> holidays = new List<DateTime>();

       
        static void Main(string[] args)
        {
            holidays.Add( new DateTime(2019, 1, 1, 4, 0, 14) );
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

            Console.WriteLine();
            Console.Write(date1);
            Console.WriteLine("   " + date1.DayOfWeek);

            Console.Write(date2);
            Console.WriteLine("   " + date2.DayOfWeek);


            Console.WriteLine("hello, you may type anything to continue");
            string name = Console.ReadLine();


            dts(date1, date2);


            Console.WriteLine("it worked");
           name = Console.ReadLine();
        }

        public static DateTime dts(DateTime t1, DateTime t2)
        {
            //we want t1 to be at least t2
            int value = DateTime.Compare(t1, t2);
            //Console.WriteLine(t1 + "     " + t2);
            //if(value < 0)
            //{
            //t1 = dts(t1.AddDays(1), t2);
            
            //}

            while(value < 0)
            {
               t1 = t1.AddDays(1);
                value = DateTime.Compare(t1, t2);
                Console.WriteLine(value + "  " + t1);
            }
            Console.WriteLine(t1 + "     " + t2);


            //next we want to check if it lands on a holiday
            //(assuming the list of holidays is sorted)
            foreach (var date in holidays)
            {
                int value2 = DateTime.Compare(t1, date);
                Console.WriteLine(t1 + "     " + t2);
                if (value == 0)
                {
                    t1.AddDays(1);
                }
            }   






            

            return t1;
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
