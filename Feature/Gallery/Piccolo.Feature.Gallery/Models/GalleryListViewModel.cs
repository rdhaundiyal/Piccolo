using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Piccolo.Feature.Gallery.Models
{
        [SitecoreType]
    public class GalleryListViewModel:GlassBase
    {
            [SitecoreField(FieldName = "Selected Image")]
            public IEnumerable<ImageArticle> ImageArticles { get; set; }
    }
}