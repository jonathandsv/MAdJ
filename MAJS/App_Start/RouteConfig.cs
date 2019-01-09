using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MAJS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "eventos/index",
                url: "eventos/index",
                defaults: new { controller = "Evento", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NovoEvento",
                url: "NovoEvento",
                defaults: new { controller = "Evento", action = "NovoEvento", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
