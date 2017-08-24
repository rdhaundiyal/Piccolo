using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Piccolo.Foundation.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Links;

namespace Piccolo.Feature.Navigation.Models
{
    public class MenuItem : CustomItem
    {
        public MenuItem(Item item)
            : base(item)
        {
            Assert.IsNotNull(item, "item");
        }

      

        public string MenuTitle
        {
            get { return InnerItem[FieldId.MenuTitle]; }
        }

        public bool ShowItemInMenu
        {
            get { return InnerItem[FieldId.ShowItemInMenu] == "1" ? true : false; }
        }


        public bool ShowChildrenInMenu
        {
            get { return InnerItem[FieldId.ShowChildrenInMenu] == "1" ? true : false; }
        }

        public bool IsActive
        {
            get { return Sitecore.Context.Item.ID == InnerItem.ID; }
        }

        public bool IsActiveADescendant
        {
            get
            {
                return Sitecore.Context.Item.ID == InnerItem.ID ||
                       InnerItem.Axes.SelectItems(String.Format(".//*[@@id = '{0}']", Sitecore.Context.Item.ID)) != null;
            }

        }

        public string Url
        {
            get { return LinkManager.GetItemUrl(InnerItem); }
        }

        public bool HasChildrenToShowInMenu
        {
            get { return ChildrenInMenu.Any(); }
        }



        public Item Item
        {
            get { return InnerItem; }
        }

        public IEnumerable<MenuItem> ChildrenInMenu
        {
            get { return ChildrenInCurrentLanguage.Where(x => x.Item["Show Item in Menu"] == "1"); }
        }



        public IEnumerable<MenuItem> ChildrenInCurrentLanguage
        {
            get { return Children.Where(x => SiteConfiguration.DoesItemExistInCurrentLanguage(x.Item)); }
        }

        public IEnumerable<MenuItem> Children
        {
            get { return InnerItem.Children.Select(x => new MenuItem(x)); }
        }
    }

    public static class FieldId
    {
   
        public static readonly ID MenuTitle = new ID("{93DF3310-E9FF-435E-B2A7-BF82E26869C3}");
        public static readonly ID ShowItemInMenu = new ID("{9F577BFD-68FA-406D-9C84-F271D2637DCC}");
        public static readonly ID ShowItemInFooter = new ID("{F3B1D89A-72DC-4FDD-B845-FFF624CF22C7}");
        public static readonly ID ShowChildrenInMenu = new ID("{5E1CFAEB-2BD3-4501-BEAD-AE02DC63B75F}");
    }
}