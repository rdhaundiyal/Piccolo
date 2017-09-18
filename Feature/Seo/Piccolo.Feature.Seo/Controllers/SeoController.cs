using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Piccolo.Feature.Seo.Models;
using Piccolo.Foundation.Base.Controllers;

namespace Piccolo.Feature.Seo.Controllers
{
    public class SeoController : BaseController
    {
        //
        // GET: /Seo/
        public ActionResult PageMetadata()
        {
            
            var result = GetItem<Metadata>();
            return View(result);
        }
	}
}
