using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DCalendar
{
    //create the class of Week and Days 
    public class WeekDayNode
    {
        public WeekDayNode Next;
        public string day;
        public int date;
        public WeekDayNode(string day, int date)
        {
            this.date = date;
            this.day = day;
            this.Next = null;
        }
    }
    class WeekDay
    {
        WeekDayNode front = null;
        WeekDayNode rear = null;

        //add the current node at the begining of the list
        public void Enqueue(string day, int date)
        {
            WeekDayNode weekDayObject = new WeekDayNode(day, date);
            if (front == null)
            {
                front = weekDayObject;
            }
            else
            {
                rear = front;
                while (rear.Next != null)
                {
                    rear = rear.Next;
                }
                rear.Next = weekDayObject;
            }
        }
        //remove the element fm 
        public WeekDayNode Dequeue()
        {
            if (front == null)
            {
                return null;
            }
            else
            {
                rear = front;
                front = front.Next;
            }
            return rear;
        }

    }
}
