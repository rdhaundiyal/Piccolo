using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Serialization;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;

namespace Piccolo.Project.Web.App_Start
{
    public class AutofacConfig
    {

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            ////Register your Web API controllers.  
            //builder.RegisterControllers(Assembly.GetExecutingAssembly());
            ////right now for brevity I am not using parameter based dependency injection but IServiceProvider can be assigned any class based on parameter name
            //builder.RegisterType<XmlChequeServiceProvider>()
            //    .As<IServiceProvider>().WithParameter(XmlDataFilePath, Settings.ChequeDataXmlPath).InstancePerApiRequest();
            //builder.RegisterType<ChequeRepository>().As<IRepository<Cheque>>().InstancePerDependency();
            //builder.RegisterInstance(AutomapperConfig.GetMapper()).As<IMapper>();
            //builder.RegisterType<Log4NetLogger>().As<ILogger>();
            //builder.RegisterType<XmlSerializer>().As<ISerializer>();
            //Container = builder.Build();

            //return Container;
        }  
    }
}