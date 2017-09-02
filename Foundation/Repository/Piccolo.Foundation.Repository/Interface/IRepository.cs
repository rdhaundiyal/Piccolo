using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sitecore.Data;

namespace Piccolo.Foundation.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(ID startPath = null, Dictionary<string, object> parameters = null);
    }
}
