using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Piccolo.Foundation.Base;

namespace Piccolo.Feature.Home.Models
{
  public   class Article:GlassBase
    {
        [SitecoreField]
        string Title { get; set; }
        [SitecoreField]
        string SubTitle { get; set; }
        [SitecoreField]
        string Description { get; set; }
        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink, FieldName = "Call To Action")]
        Link CallToAction { get; set; }
    }
}
