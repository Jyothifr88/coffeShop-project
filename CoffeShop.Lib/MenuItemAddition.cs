using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeShop.Lib
{
    [Serializable()]
    public class MenuItemAddition:MenuItem
    {

        MenuItem menuitem;
        

        public MenuItemAddition(MenuItem menuitem)
        {
            this.menuitem = menuitem;
        }

        public MenuItem MenuItem
        {
            get { return menuitem; }
            set { menuitem = value; }

        }
    }
}
