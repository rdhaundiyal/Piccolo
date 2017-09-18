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
    public class Article:GlassBase
    {
        [SitecoreField]
        public virtual string Title { get; set; }
        [SitecoreField]
        public virtual string SubTitle { get; set; }
        [SitecoreField]
        public virtual string Description { get; set; }
        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink, FieldName = "Call To Action")]
        public virtual Link CallToAction { get; set; }
    }
}
 
