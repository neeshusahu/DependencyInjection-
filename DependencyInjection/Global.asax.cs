﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DependencyInjection.Data.Model;
using DependencyInjection.Data.Context;
using DependencyInjection.ControllerFactoryRepositories;
using System.Data.Entity;

namespace DependencyInjection
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            var root = new CompositionRoot();
            ControllerBuilder.Current.SetControllerFactory(root.ControllerFactory);
            Database.SetInitializer<DetailsContext>(new DropCreateDatabaseIfModelChanges<DetailsContext>());
        }
    }
}
