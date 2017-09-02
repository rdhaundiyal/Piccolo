using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Feature.Gallery.Repository;

namespace Piccolo.Feature.Gallery.Controllers
{
    public class GalleryController : Controller
    {
        private IRepository<ImageArticle> _imageArticleRepository;
        public GalleryController(IRepository<ImageArticle> imageArticleRepository)
        {
            _imageArticleRepository = imageArticleRepository;
        }
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

        public ActionResult Search(string searchTerm = "")
        {
            var rootPath = Sitecore.Context.Database.GetItem("/sitecore/content/Home/Album");

          //  var repository=new ImageArticleRepository1();
            var dict = new Dictionary<string, object>();
            dict.Add("Services","Web");
            //var result = repository.GetArticles(rootPath.ID,searchTerm);
            var result = _imageArticleRepository.Get(rootPath.ID, dict);
            return View(result);
        }
    }
}