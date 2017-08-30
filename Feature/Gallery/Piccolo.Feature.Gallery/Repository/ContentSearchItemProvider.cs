using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Sitecore.ContentSearch.Linq;

namespace Piccolo.Feature.Gallery.Repository
{
    public class ContentSearchItemProvider:ISearchResultItemProvider
    {
        public IEnumerable<T> Get<T>() where T : Sitecore.ContentSearch.SearchTypes.SearchResultItem
        {
            using (
                var context =
                    Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(
                        new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                var query = context.GetQueryable<T>();
            // query = query.Where(whereCondition);
             //   query = query.Where(k => string.Equals(k.TemplateName, "image article", StringComparison.InvariantCultureIgnoreCase) || string.Equals(k.TemplateName, "picture", StringComparison.InvariantCultureIgnoreCase));
                //if (serviceTag != "" && serviceTag.ToLower() == "all")
                //{ query = query.Where(k => k.Services.Contains(serviceTag)); }
              
                var results = query.GetResults();
                if (results == null || !results.Any()) return null;
                var data = results.Hits.Where(k => k.Document != null).Select(k => k.Document);
                return data;
            }
          
        }
    }
}