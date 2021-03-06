﻿using System;
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
                name: "Home/Index",
                url: "Home/Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Ensaio/Index",
                url: "Ensaio/Index",
                defaults: new { controller = "Ensaio", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Evento/Index",
                url: "Evento/Index",
                defaults: new { controller = "Evento", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "NovoEvento",
                url: "NovoEvento",
                defaults: new { controller = "Evento", action = "NovoEvento", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Repertorio/Index",
                url: "Repertorio/Index",
                defaults: new { Controller = "Repertorio", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Evento/DeleteEvento",
                url: "Evento/DeleteEvento",
                defaults: new { Controller = "Evento", action = "DeleteEvento", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
