using System;

namespace _2DCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Calender");
            MonthlyCalendar calender = new MonthlyCalendar();
            calender.PrintCalender("July", 2021);
            calender.DisplayCalender();
            calender.DisplayQueue();
        }
    }
}
