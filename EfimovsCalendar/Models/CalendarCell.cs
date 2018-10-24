using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfimovsCalendar.Models
{
    public class CalendarCell
    {
        List<CalendarEvent> events = new List<CalendarEvent>();
        DateTime date;
        String className = "";
        public int index = 0;

        public DateTime Date { get => date; set => date = value; }
        public List<CalendarEvent> Events { get => events; set => events = value; }
        public string ClassName { get => className; set => className = value; }

        public CalendarCell(DateTime date, int index)
        {
            this.index = index;
            this.date = date;
            // TODO: получение событий из базы данных

        }

        private void getEvents()
        {
            
        }
    }
}