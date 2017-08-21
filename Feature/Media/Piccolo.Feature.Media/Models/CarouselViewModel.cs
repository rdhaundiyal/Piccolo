using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Piccolo.Feature.Media.Models
{
    [SitecoreType]
    public class CarouselViewModel:GlassBase
    {
        [SitecoreField(FieldName = "Selected Items")]
        public IEnumerable<CarouselSlides> CarouselSlides { get; set; }
    }
}