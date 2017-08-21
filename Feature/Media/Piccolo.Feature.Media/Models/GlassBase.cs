using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Piccolo.Feature.Media.Models
{
    public class GlassBase
    {

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string Template { get; set; }
    }
}