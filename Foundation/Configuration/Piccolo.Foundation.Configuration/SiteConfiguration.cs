using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piccolo.Foundation.Configuration
{
   public class SiteConfiguration
    {
        public static Item GetSiteConfigurationItem()
        {
            return Sitecore.Context.Database.GetItem(String.Format("{0}/Configuration", GetHomeItem().Paths.FullPath));
        }
        public static bool DoesItemExistInCurrentLanguage(Item i)
        {
            // standard way of checking
            return i.Versions.Count != 0;
        }

       public static Item GetHomeItem()
        {
            // Since we want to support multi-site for evaluation purposes and do not create site nodes in the site section of 
            // the web.config, we will just go up the tree until we get to the content node.
            Item temp = Sitecore.Context.Item;
            Item contentNode = Sitecore.Context.Database.GetItem("/sitecore/content");
            while (temp.Parent != null && temp.ParentID != contentNode.ID)
            {
                temp = temp.Parent;
            }
            return temp;

            // This is the best way to get the home node, but it only works if there is a site definition in the web.config
            //return Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);

            // These options are also ways to get to the home node.
            //return Sitecore.Context.Item.Axes.SelectSingleItem("ancestor-or-self::*[@@templatekey='home']");
            //return Sitecore.Context.Database.GetItem("/sitecore/content/home");

            // There are multiple ways to retrieve the home node.  You can reference the path, but this is bad for multisite installs.  
            // You can also check by template if all items share the same template type, but my favorite way is to use the StartPath 
            // which is on the site definition node in the config file.
        }
    }
}
