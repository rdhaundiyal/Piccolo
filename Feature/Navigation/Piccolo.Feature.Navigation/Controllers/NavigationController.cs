using Piccolo.Foundation.Configuration;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Piccolo.Feature.Navigation.Controllers
{
    public class NavigationController : Sitecore.Mvc.Controllers.SitecoreController
    {
        // GET: Navigation
        public ActionResult Header()
        {
            // This page is setting a lot fo the presentation details.  This is due tot he flexible nature of this site.
            Item presentationSettings = SiteConfiguration.GetSiteConfigurationItem();
            if (presentationSettings != null)
            {
                return PartialView("Header", presentationSettings);
            }
            return null;
           
        }
        public ActionResult Footer()
        {
            return PartialView();
        }
        //public ActionResult SitesNavigation()
        //{
        //    Item contentNode = SiteConfiguration.GetHomeItem().Parent;
        //    List<GenericLink> sites = new List<GenericLink>();

        //    foreach (Item site in contentNode.Children.ToArray().Where(item => SiteConfiguration.DoesItemExistInCurrentLanguage(item)))
        //    {
        //        if (site["Show in Sites Menu"] == "1") { sites.Add(new GenericLink(site["Site Name"], LinkManager.GetItemUrl(site), false)); }
        //    }

        //    if (SiteConfiguration.GetExternalSitesItem() != null)
        //    {
        //        foreach (Item externalsite in SiteConfiguration.GetExternalSitesItem().Children)
        //        {
        //            if (SiteConfiguration.DoesItemExistInCurrentLanguage(externalsite))
        //            {
        //                Sitecore.Data.Fields.LinkField lf = externalsite.Fields["Site Link"];
        //                sites.Add(new GenericLink(lf.Text, lf.Url, true));
        //            }
        //        }
        //    }

        //    // Don't show the drop down unless there are multiple sites
        //    return (sites.Count > 1) ? View("TertiaryNavigationPartialSites", sites as IEnumerable<GenericLink>) : null;
        //}
    }
}