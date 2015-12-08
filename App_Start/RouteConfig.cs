using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace unity_getting_started
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ekPages",
                url: "{*urlAlias}",
                defaults: new { controller = "Default", action = "Index", urlAlias = UrlParameter.Optional }
            );
        }
    }
}