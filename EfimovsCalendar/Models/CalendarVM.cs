using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarVM
    {
        public struct DayMonth
        {
            int month;
            int year;

            public DayMonth(int month, int year)
            {
                this.month = month;
                this.year = year;
            }

            public int Month { get => month;}
            public int Year { get => year;}
        }

        int currentMonth;
        int currentYaer;
        string monthName;

        public DayMonth nextMonth
        {
            get
            {
                DayMonth temp = new DayMonth();
                return temp;
            }
        }
    }

    
}