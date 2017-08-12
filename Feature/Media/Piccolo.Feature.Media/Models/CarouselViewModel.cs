using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Piccolo.Feature.Media.Models
{
    public class CarouselViewModel
    {
        public IList<CarouselSlideViewModel> CarouselSlides { get; set; }
    }
}