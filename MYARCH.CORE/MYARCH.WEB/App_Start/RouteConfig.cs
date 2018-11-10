using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MYARCH.WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
<<<<<<< HEAD
                defaults: new { controller = "Manager", action = "Index", id = UrlParameter.Optional }
=======
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
>>>>>>> 0a37828e9e0112a3f2e9952f4c671339756b719c
            );
        }
    }
}
