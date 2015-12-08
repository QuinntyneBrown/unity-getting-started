using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace unity_getting_started
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents(); 
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}