﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.Foundation.Configuration.Models
{
   public class GenericLink
    {
        public GenericLink(string title, string url, bool openInBlankWindow)
        {
            Title = title;
            Url = url;
            OpenInBlankWindow = openInBlankWindow;
        }

        public string Title
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }

        public bool OpenInBlankWindow
        {
            get;
            set;
        }
    }
}
