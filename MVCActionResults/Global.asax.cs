using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCActionResults
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //ViewEngines.Engines.Clear();
            //ViewEngines.Engines.Add(new RazorViewEngine());
            //ViewEngines.Engines.Remove(ViewEngines.Engines.OfType<WebFormViewEngine>().FirstOrDefault());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
