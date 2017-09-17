using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Piccolo.Foundation.Base;

namespace Piccolo.Feature.Gallery.Models
{
        [SitecoreType]
    public class GalleryListViewModel:GlassBase
    {
            [SitecoreField(FieldName = "Selected Image")]
            public IEnumerable<ImageArticle> ImageArticles { get; set; }

            [SitecoreField]
            public string Title { get; set; }
            [SitecoreField(FieldType = SitecoreFieldType.GeneralLink, FieldName = "Call To Action")]
            public Link CallToAction { get; set; } 

    }
}
