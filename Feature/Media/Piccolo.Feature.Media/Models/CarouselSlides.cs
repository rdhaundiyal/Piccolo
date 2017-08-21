using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Piccolo.Feature.Media.Models
{
    [SitecoreType]
    public class CarouselSlides:GlassBase
    {
           [SitecoreField(FieldType = SitecoreFieldType.Image, FieldName = "Image")]
        public virtual Image Image { get; set; }

     
    }
}