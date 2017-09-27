using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Piccolo.Foundation.Base;

namespace Piccolo.Feature.Forms.Models
{
    public class Address : GlassBase
    {
        [SitecoreField(FieldName = "Name")]
        public string CompanyName { get; set; }

        [SitecoreField(FieldName = "Address First Line")]
        public string AddressFirstLine { get; set; }

        [SitecoreField(FieldName = "Address Second Line")]
        public string AddressSecondLine { get; set; }
        [SitecoreField]
        public string City { get; set; }
        [SitecoreField]
        public string Postcode { get; set; }
        [SitecoreField]
        public string Phone { get; set; }
        [SitecoreField(FieldName = "Contact Name")]

        public string ContactPersonName { get; set; }
        [SitecoreField(FieldName = "Contact Email")]
        public string ContactEmail { get; set; }

        [SitecoreField(FieldName = "Map Coordinate")]
        public string Coordinates { get; set; }

    }
}
