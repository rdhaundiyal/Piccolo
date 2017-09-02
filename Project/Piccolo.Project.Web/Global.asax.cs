using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Piccolo.Project.Web.App_Start;

namespace Piccolo.Project.Web
{
    public class MvcApplication : Sitecore.Web.Application
    {
        protected void Application_Start()
        {
          //  AutofacConfig.RegisterContainer();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
