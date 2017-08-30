using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using Piccolo.Feature.Gallery.Models;
using Sitecore.ContentSearch.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.DynamicProxy.Generators.Emitters;
using Glass.Mapper.Sc;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Data;

namespace Piccolo.Feature.Gallery.Repository
{
    public abstract class BaseRepository<T,T1>:IRepository<T> where T:class
        where T1:SearchResultItem
    {
        public IEnumerable<T> Get()
        {
            using (
                var context =
                    Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(
                        new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                var query = context.GetQueryable<T1>();
                var results = query.GetResults();
                if (results != null && results.Any())
                {
                    var data = results.Hits.Where(k => k.Document != null).Select(k => k.Document);
                    var service = new SitecoreService(Sitecore.Context.Database);
                    return data.Select(doc => service.CreateType<T>(doc.GetItem())).Where(item => item != null).ToList();
                }
                return null;
            }
         
        }
    }
}