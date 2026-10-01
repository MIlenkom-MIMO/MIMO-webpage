using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MIMOWEB_ENG_NEW
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index"},
                new[] { "MIMOWEB_ENG.Controllers" }
            );

            routes.MapRoute(
                name: "Services",
                url: "{controller}/{action}",
                defaults: new { controller = "Service", action = "Service" },
                new[] { "MIMOWEB_ENG.Controllers" }

            );

            //routes.MapRoute(
            //    name: "ServiceEN",
            //    url: "{lang}/{controller}/{action}",
            //    defaults: new { controller = "Service", action = "Service", lang = "EN" }
            //);

        }
    }
}
