using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TraditionalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            //routes.MapRoute(
            //    name: "StudentAbout",
            //    url: "Aboutstudent",
            //    defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "StudentContact",
            //    url: "Contactstudent",
            //    defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "Student",
            //    url: "Student",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
