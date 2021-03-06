﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

            public int Month { get => month; }
            public int Year { get => year; }
        }

        int currentMonth;
        int currentYear;
        string monthName;
        List<CalendarCell> cells;

        public CalendarVM(DateTime date)
        {
            cells = new List<CalendarCell>();
            currentMonth = date.Month;
            currentYear = date.Year;
            monthName = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
        }

        public int CurrentMonth { get => currentMonth; set => currentMonth = value; }
        public int CurrentYear { get => currentYear; set => currentYear = value; }
        public string MonthName { get => monthName; set => monthName = value; }
        public List<CalendarCell> Cells { get => cells; set => cells = value; }

        public DayMonth Next
        {
            get
            {
                int month = CurrentMonth < 12 ? CurrentMonth + 1 : 1;
                int year = CurrentMonth < 12 ? CurrentYear : CurrentYear + 1;
                return new DayMonth(month, year);
            }
        }
        public DayMonth Previous
        {
            get
            {
                int month = CurrentMonth > 1 ? CurrentMonth - 1 : 12;
                int year = CurrentMonth > 1 ? CurrentYear : CurrentYear - 1;
                return new DayMonth(month, year);
            }
        }
    }


}