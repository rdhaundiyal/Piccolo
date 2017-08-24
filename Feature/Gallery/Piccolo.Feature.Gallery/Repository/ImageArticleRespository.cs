using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using Piccolo.Feature.Gallery.Models;
using Piccolo.Feature.Gallery.Models.Search;
using Sitecore.ContentSearch.Linq;

namespace Piccolo.Feature.Gallery.Repository
{
    public class ImageArticleRespository
    {
        public IEnumerable<ImageArticle> GetArticles(string serviceTag="")
        {
            using (
                var context =
                    Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(
                        new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                var query = context.GetQueryable<ImageArticleSearchItem>();
                if (serviceTag != "" && serviceTag.ToLower() == "all")
                { query = query.Where(k => k.Services.Contains(serviceTag)); }
              
                var results = query.GetResults();
                if (results != null && results.Any())
                {
                    var data = results.Hits.Where(k => k.Document != null).Select(k=>k.Document);
                    var resultset=new List<ImageArticle>();
                    var service=new SitecoreService(Sitecore.Context.Database);
                    foreach (var doc in data)
                    {
                     var item=   service.CreateType<ImageArticle>(doc.GetItem());
                        if (item != null)
                        {
                            resultset.Add(item);
                        }
                    }
                    return resultset;
                }
            }
            return null;
        }
    }
}