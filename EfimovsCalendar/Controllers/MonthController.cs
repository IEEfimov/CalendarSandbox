using EfimovsCalendar.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfimovsCalendar.Controllers
{
    public class MonthController : Controller
    {
        public ActionResult Index(int? year, int? month)
        {
            Logic logic = new Logic();
            CalendarVM model = logic.getModel(year, month);

            return View(model);

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