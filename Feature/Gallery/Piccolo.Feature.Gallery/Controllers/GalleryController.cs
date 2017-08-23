using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Piccolo.Feature.Gallery.Models;

namespace Piccolo.Feature.Gallery.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult List()
        {
            var item = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            var context = new SitecoreContext();
            var result = context.GetItem<GalleryListViewModel>(item.Paths.Path);
            return View("List", result);
        }

        public ActionResult Detail()
        {
            var context = new SitecoreContext();
            var result = context.GetCurrentItem<ImageArticle>();

           
            return View(result);
        }
    }
}