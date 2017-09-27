using System.Collections.Generic;
using System.Web.Mvc;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Foundation.Base.Controllers;
using Piccolo.Foundation.Repository.Interface;

namespace Piccolo.Feature.Gallery.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IRepository<ImageArticle> _imageArticleRepository;
        public GalleryController(IRepository<ImageArticle> imageArticleRepository)
        {
            _imageArticleRepository = imageArticleRepository;
        }
        // GET: Gallery
        public ActionResult List()
        {
            var item = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            var result = GetItem<GalleryListViewModel>(item.Paths.Path);
            return View("List", result);
        }

        public ActionResult Detail()
        {
            var result = GetItem<ImageArticle>();
            return View(result);
        }

        public ActionResult Search(string searchTerm = "")
        {
            var rootPath = Sitecore.Context.Database.GetItem("/sitecore/content/Home/Album");
            var dict = new Dictionary<string, object> { { "Services", "Web" } };
            var result = _imageArticleRepository.Get(rootPath.ID, dict);
            return View(result);
        }
    }
}
