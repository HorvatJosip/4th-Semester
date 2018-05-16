using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Zadatak_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Korijen",
                url: "Korijen/{broj}",
                defaults: new { controller = "Matematika", action = "Korijen" },
                constraints: new { broj = @"-?\d{1,2}" }//- moze, a ne mora bit, nakon toga digit {min, max} (jedno ili dvoznamenkasti)
            );

            routes.MapRoute(
                name: "Admin",
                url: "Admin",
                defaults: new { controller = "Admin", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{ime}",
                defaults: new { controller = "Moj", action = "PozdraviOsobu", ime = UrlParameter.Optional }
            );
        }
    }
}
