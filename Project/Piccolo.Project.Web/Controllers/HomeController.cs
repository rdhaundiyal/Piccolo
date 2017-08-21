using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Ui;

using Piccolo.Project.Web.Models;
namespace Piccolo.Project.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var context = new SitecoreContext();
            var result = context.GetCurrentItem<IArticle>();
        
            return View(result);
        }
	}
}