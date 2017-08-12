using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc;
using Sitecore.Data.Items;
using System.Web.Mvc;

namespace Piccolo.Feature.Media.Models
{
    public class CarouselSlideViewModel
    {
        public Item Item { get; set; }
        public MvcHtmlString Image
        {
            get { return GetFieldValue("Image"); }
        }

        public MvcHtmlString CallToAction
        {
            get { return GetFieldValue("CallToAction"); }
        }
        private MvcHtmlString GetFieldValue(string fieldName)
        {
            return new MvcHtmlString(Sitecore.Web.UI.WebControls.FieldRenderer.Render(Item, fieldName));
        }
    }
}