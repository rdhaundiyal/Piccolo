using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
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

         [IndexField("Date")]
        public DateTime Date { get; set; }

         [IndexField("Client")]
        public  string Client { get; set; }
      
   
        [IndexField("Art Director")]
        public  string ArtDirector { get; set; }
         [IndexField("Designer")]
        public  string Designer { get; set; }
       [IndexField("Image")]
        public  Image Image { get; set; }

        [IndexField("Thumbnail Image")]
        public  Image ThumbnailImage { get; set; }
    }
}