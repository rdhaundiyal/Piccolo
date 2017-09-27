using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Piccolo.Foundation.Base;
namespace Piccolo.Feature.Forms.Models
{
    public class Contact:GlassBase
    {
        [SitecoreField]
        public string Title { get; set; }
        [SitecoreField(FieldName = "SubTitle")]
        public string Description { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Body { get; set; }

        public string Message { get; set; }
    }
}
