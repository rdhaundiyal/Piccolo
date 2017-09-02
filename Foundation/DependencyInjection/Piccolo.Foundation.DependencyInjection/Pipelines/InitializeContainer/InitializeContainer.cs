using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Sitecore.Pipelines;

namespace Piccolo.Foundation.DependencyInjection.Pipelines.InitializeContainer
{
    public class InitializeContainer
    {
        public void Process(PipelineArgs args)
        {
            var builder = new ContainerBuilder();
           
            // Register dependencies in controllers
           
            var assembliesInAppDomain = AppDomain.CurrentDomain.GetAssemblies().ToArray();
            builder.RegisterControllers(assembliesInAppDomain);
            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

          
            builder.RegisterAssemblyModules(assembliesInAppDomain);
           

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}