using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Piccolo.Foundation.Base;

namespace Piccolo.Feature.Seo.Models
{
  public  class Metadata:GlassBase
    {
    public    string PageTitle { get; set; }
    public string SiteTitle { get; set; }
            [SitecoreField( FieldName = "Metadata-Description")]
    public string Description { get; set; }
        public    string KeywordsList { get; set; }
            [SitecoreField( FieldName = "Metadata-Title")]
            public string Title { get; set; }
            public ICollection<string> Robots { get; set; }
     
            public NameValueCollection CustomMetadata { get; set; }
    }
}
