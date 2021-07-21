using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCalendar
{
   public  class MonthlyCalendar
    {
        //array for storing the the calender
        string[,] calender = new string[6, 7];
        //dictionary to get the index for the month
        Dictionary<string, int> month = new Dictionary<string, int>() { { "January", 0 }, { "February", 1 }, { "March", 2 }, { "April", 3 }, { "May", 4 }, { "June", 5 }, { "July", 6 }, { "August", 7 }, { "September", 8 }, { "October", 9 }, { "November", 10 }, { "December", 11 } };
        //create the object for the queue
        WeekDay week = new WeekDay();
        //initaialize the array with empty string
        public  MonthlyCalendar()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    calender[i, j] = "  ";
                }
            }
        }
        //check whether the given year is leap year or not to check for feburary date
        public int FindLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        //to calculate the end date like 31 or 30 or 28 or 29
        public int CaluculateEndDay(string month, int year)
        {
            int mon = this.month[month];
            //if month is jan or march etc..
            if (mon == 0 || mon == 2 || mon == 4 || mon == 6 || mon == 7 || mon == 9 || mon == 11)
            {
                return 31;
            }
            //if month is february check for leap year and return the date
            else if (mon == 1)
            {
                return (28 + FindLeapYear(year));
            }
            //else the end date is 30
            else
            {
                return 30;
            }
        }
        //to calculate which day the month starts
        public int CalculateWeek(int dd, string month1, int yy)
        {
            //temp local variables
            int temp;
            int y0, m0, week;
            int mm = month.GetValueOrDefault(month1);
            mm++;
            //formula for Gregorian calendar 
            y0 = yy - (14 - mm) / 12;
            temp = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = mm + 12 * ((14 - mm) / 12) - 2;
            week = (dd + temp + 31 * m0 / 12) % 7;
            //it retures the day from whixh the month start
            return week;
        }

        public void PrintCalender(string mon, int year)
        {
            //calculate the start day
            int startDay = CalculateWeek(1, mon, year);
            int day = 1;
            //calculate the total number of days in that month
            int endDay = CaluculateEndDay(mon, year);
            Console.WriteLine("\n     {0}  {1}", mon, year);
            //store the result in the calender
            for (int i = 0; i < 6; i++)
            {
                //for first iteration the month starts from calculated day
                for (int j = startDay; j < 7; j++)
                {
                    //check the total number of days in month is reached
                    if (day > endDay)
                    {
                        break;
                    }
                    //store the day in the array as string
                    calender[i, j] = day.ToString("D2");
                    day++;
                }
                //from second iteration the statday will be 0
                startDay = 0;
            }
        }
        //display the result that is stored
        public void DisplayCalender()
        {
            Console.WriteLine(" S  M  T  W  T  F  S ");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("{0} ", calender[i, j]);
                }
                Console.WriteLine();
            }
        }
        //display the queue
        public void DisplayQueue()
        {
            WeekDayNode dayNode = week.Dequeue();
            while (dayNode != null)
            {
                Console.WriteLine("{0}   {1}", dayNode.day, dayNode.date);
                dayNode = week.Dequeue();
            }
        }
    }
}
