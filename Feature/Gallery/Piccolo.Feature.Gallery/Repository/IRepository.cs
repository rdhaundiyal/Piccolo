using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.Feature.Gallery.Repository
{
  public  interface IRepository<T> where T:class
  {
      IEnumerable< T> Get();
  }
}
