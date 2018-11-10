<<<<<<< HEAD
﻿using MYARCH.IoC;
using System;
=======
﻿using System;
>>>>>>> 0a37828e9e0112a3f2e9952f4c671339756b719c
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MYARCH.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
<<<<<<< HEAD
            UnityConfig.RegisterComponents();
=======
>>>>>>> 0a37828e9e0112a3f2e9952f4c671339756b719c
        }
    }
}
