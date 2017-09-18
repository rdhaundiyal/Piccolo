using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Feature.Gallery.Repository;
using Piccolo.Foundation.Repository.Interface;

namespace Piccolo.Feature.Gallery.Modules
{
    public class GalleryModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ImageArticleRepository>().As<IRepository<ImageArticle>>();


        }
    }
}
