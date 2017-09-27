using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Piccolo.Feature.Forms.Models;
using Glass.Mapper.Sc;
using Piccolo.Foundation.Base;
using Piccolo.Foundation.Base.Controllers;
namespace Piccolo.Feature.Forms.Controllers
{
    public class ContactUsController : BaseController
    {
        //
        // GET: /ContactUs/
        public ActionResult Contact()
        {
            var context = new SitecoreContext();
            var result = context.GetCurrentItem<Contact>();

            return View(result);
        }
        [HttpPost]
        public ActionResult Contact(Piccolo.Feature.Forms.Models.Contact contact)
        {

            var context = new SitecoreContext();
            var result = context.GetCurrentItem<Contact>();
            result.Message =string.Format( Helper.GetDictionaryItem("ContactFormSuccessMessage"),contact.ContactName);
            return View(result);
      
        }

        public ActionResult Location()
        {

            var item = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            var context = new SitecoreContext();
            var result = context.GetItem<Address>(item.Paths.Path);
            return View("Location", result);
            
        }
	}
}
