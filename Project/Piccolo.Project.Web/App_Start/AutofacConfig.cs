//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Web;
//using System.Web.Mvc;
//using System.Xml.Serialization;
//using Autofac;
//using Autofac.Core;
//using Autofac.Integration.Mvc;


//namespace Piccolo.Project.Web.App_Start
//{
//    public class AutofacConfig
//    {

//        public static void RegisterContainer()
//        {
//            var builder = new ContainerBuilder();

//            // Register dependencies in controllers
//            builder.RegisterControllers(typeof(MvcApplication).Assembly);

//            // Register dependencies in filter attributes
//            builder.RegisterFilterProvider();

//            // Register dependencies in custom views
//            builder.RegisterSource(new ViewRegistrationSource());

//            // Register our Data dependencies
//         //   builder.RegisterModule(new GalleryModule());

//            var container = builder.Build();

//            // Set MVC DI resolver to use our Autofac container
//            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
//        }
//    }
//}