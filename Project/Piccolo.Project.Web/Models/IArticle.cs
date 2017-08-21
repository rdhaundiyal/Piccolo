using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
namespace Piccolo.Project.Web.Models
{
    public interface IArticle:IGlassBase
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
