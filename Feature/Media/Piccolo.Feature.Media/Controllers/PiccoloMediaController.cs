﻿using Piccolo.Feature.Media.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Sitecore.Mvc;
namespace Piccolo.Feature.Media.Controllers
{
    public class PiccoloMediaController : Controller
    {
        // GET: Media
        public ActionResult Carousel()
        {
            var item = Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.Item;
            var context = new SitecoreContext();
            var result = context.GetItem<CarouselViewModel>(item.Paths.Path);


            //var slideIds = Sitecore.Data.ID.ParseArray(item["Selected Items"]);
            //var viewModel = new CarouselViewModel
            //{
            //    CarouselSlides =
            //        slideIds.Select(i =>
            //            new CarouselSlideViewModel
            //            {
            //                Item = item.Database.GetItem(i)
            //            }).ToList()
            //};
            return View("Carousel", result);
            
        }
    }
}