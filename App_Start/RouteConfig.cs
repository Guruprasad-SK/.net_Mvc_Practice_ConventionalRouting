using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConventionalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "allStudent",
               url: "student",
               defaults: new { controller = "Student", action = "GetAllStudent" });

            routes.MapRoute(
               name: "Student",
               url: "student/{id}",
               defaults: new { controller = "Student", action = "GetStudentId" });

            routes.MapRoute(
               name: "StudentAddress",
               url: "student/{id}/Address",
               defaults: new { controller = "Student", action = "GetStudentAddress" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
