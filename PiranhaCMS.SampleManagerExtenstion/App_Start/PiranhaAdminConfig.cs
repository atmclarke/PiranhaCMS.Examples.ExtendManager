using Piranha.WebPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiranhaCMS.SampleManagerExtenstion.App_Start
{
    public class PiranhaAdminConfig
    {
        public static void RegisterAdminMenu()
        {
            Manager.Menu.Add(new Manager.MenuGroup()
            {
                InternalId = "ProductApp",
                Name = "Products",
                CssClass = "fancy-icon"
            });

            Manager.Menu.Where(m => m.InternalId == "ProductApp").Single().Items.Add(
              new Manager.MenuItem()
              {
                  Name = "Products",
                  Action = "index",
                  Controller = "Product",
                  Permission = "ADMIN",
                  SelectedActions = "index,edit,create" // this ties the "Products" tab to these toolbars 
              });
        }
    }
}