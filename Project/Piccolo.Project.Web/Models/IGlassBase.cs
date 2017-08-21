using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
namespace Piccolo.Project.Web.Models
{
   public interface IGlassBase
    {
       [SitecoreInfo(SitecoreInfoType.Name)]
       string Name { get; set; }
       [SitecoreInfo(SitecoreInfoType.TemplateName)]
       string Template { get; set; }
    }
}
