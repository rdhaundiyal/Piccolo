using System.Collections.Generic;
using Sitecore.ContentSearch.SearchTypes;

namespace Piccolo.Feature.Gallery.Repository
{
   public interface ISearchResultItemProvider
   {
       IEnumerable<T> Get<T>() where T : SearchResultItem;
   }
}
