using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Globalization;
namespace Piccolo.Foundation.Base
{
   
        public static class Helper
        {
            public static string GetDictionaryItem(string key)
            {
                if (string.IsNullOrEmpty(key))
                    return string.Empty;

                string dictionaryValue = string.Empty;
                dictionaryValue = Translate.Text(key);
                return dictionaryValue;
            }
        
    }
}
