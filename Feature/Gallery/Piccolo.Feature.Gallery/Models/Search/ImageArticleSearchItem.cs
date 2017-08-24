using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;

namespace Piccolo.Feature.Gallery.Models.Search
{
    public class ImageArticleSearchItem:BaseSearchItem
    {
        [IndexField("Title")]
        public string Title { get; set; }
        [IndexField("SubTitle")]
        public string SubTitle { get; set; }
        [IndexField("Services")]
        public string Services { get; set; }
    }
}