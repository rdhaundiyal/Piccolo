using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Data;

namespace Piccolo.Feature.Gallery.Repository
{
  public  interface IRepository<T> where T:class
  {
      IEnumerable<T> Get(ID startPath = null, Dictionary<string, object> parameters = null);
  }
}
