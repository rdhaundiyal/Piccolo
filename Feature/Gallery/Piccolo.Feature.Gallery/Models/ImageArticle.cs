using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Shell.Applications.ContentEditor;
using DateTime = System.DateTime;
using Image = Glass.Mapper.Sc.Fields.Image;

namespace Piccolo.Feature.Gallery.Models
{
        [SitecoreType]
    public class ImageArticle : Article
    {
            [SitecoreField]
            public virtual DateTime Date { get; set; }
           [SitecoreField]
            public virtual string Client { get; set; }
            [SitecoreField]
           public virtual string Services { get; set; }
           [SitecoreField(FieldName = "Art Director")]
            public virtual string ArtDirector { get; set; }
       [SitecoreField]
            public virtual string Designer { get; set; }
          [SitecoreField(FieldType = SitecoreFieldType.Image, FieldName = "Image")]
           public virtual Image Image { get; set; }

                    [SitecoreField(FieldType = SitecoreFieldType.Image, FieldName = "Thumbnail Image")]
          public virtual Image ThumbnailImage { get; set; }
        }
}
