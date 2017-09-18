using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Piccolo.Foundation.Base
{
    [SitecoreType(AutoMap = true)]
    public class GlassBase
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public virtual string Template { get; set; }
    }
}
