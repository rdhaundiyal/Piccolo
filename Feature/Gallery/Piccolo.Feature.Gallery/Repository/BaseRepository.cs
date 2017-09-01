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
using System.Linq.Expressions;
using System.Reflection;
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

        protected static MethodInfo ContainsMethod = typeof(string).GetMethod("Contains");
        protected static MethodInfo StartsWithMethod =typeof(string).GetMethod("StartsWith", new[] { typeof(string) });
        protected static MethodInfo EndsWithMethod =typeof(string).GetMethod("EndsWith", new[] { typeof(string) });
        public IEnumerable<T> Get(ID startPath=null, Dictionary<string,object> parameters=null )
        {
            using (
                var context =
                    Sitecore.ContentSearch.ContentSearchManager.CreateSearchContext(
                        new Sitecore.ContentSearch.SitecoreIndexableItem(Sitecore.Context.Item)))
            {
                var query = context.GetQueryable<T1>();
                var whereCondition = GetCondition(parameters);
                if (whereCondition != null)
                {
                    query = query.Where(whereCondition);
                }
                var results = query.GetResults();
                if (results == null || !results.Any()) return null;
                var data = results.Hits.Where(k => k.Document != null).Select(k => k.Document);
                var service = new SitecoreService(Sitecore.Context.Database);
                return data.Select(doc => service.CreateType<T>(doc.GetItem())).Where(item => item != null).ToList();
            }
         
        }


        public abstract Expression<Func<T1, bool>> GetCondition(Dictionary<string, object> parameters);

    }
}