using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Piccolo.Feature.Home.Models;
using Piccolo.Foundation.Base.Controllers;
using Sitecore.Mvc.Controllers;

namespace Piccolo.Feature.Home.Controllers
{
    public class HomeController :BaseController
    {
        public new ActionResult Index()
        {
            var context = new SitecoreContext();
            var result = context.GetCurrentItem<Article>();

            return View(result);
        }

    }
}
