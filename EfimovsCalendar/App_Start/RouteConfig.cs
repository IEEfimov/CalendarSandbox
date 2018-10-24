using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EfimovsCalendar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{year}/{month}",
                defaults: new { controller = "Home", action = "Index", year = UrlParameter.Optional,
                    month = UrlParameter.Optional }
            );
        }
    }
}
