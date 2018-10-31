using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class Logic
    {
        public CalendarVM getModel(int? year, int? month)
        {
            DateTime currentDate;
            if (year.HasValue && month.HasValue)
                currentDate = new DateTime((int)year, (int)month, 1);
            else currentDate = DateTime.Now;

            CalendarVM calendarVM = new CalendarVM(currentDate);
            calendarVM.Cells = getCalendarCells(currentDate);
            return calendarVM;
        }
        public List<CalendarCell> getCalendarCells(DateTime date)
        {
            var cells = new List<CalendarCell>();

            if (date.Day != 1) date = date.AddDays(-date.Day + 1);
            int dayOfWeek = (int)date.DayOfWeek;
            dayOfWeek = dayOfWeek < 1 ? 6 : dayOfWeek - 1; // Monday is 0 now;

            for (int i = -dayOfWeek; i < 35 - dayOfWeek; i++)
            {
                var tempDay = date.AddDays(i);
                CalendarCell temp = new CalendarCell(tempDay, i);
                cells.Add(temp);

                if (isSimilarDate(tempDay, DateTime.Now)) temp.ClassName = "today ";
                if (temp.Date.Month != date.Month)
                    temp.ClassName = "wrongMonth ";
            }
            for (int i = 0; i < 15; i++) cells[9].Events.Add(
                new CalendarEvent($"Cобытие событие событие {i} ", i));

            return cells;
        }

        public bool isSimilarDate(DateTime a, DateTime b)
        {
            if (a.Day != b.Day) return false;
            if (a.Month != b.Month) return false;
            if (a.Year != b.Year) return false;

            return true;
        }

        
    }
}