using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
   public class Mayo:MenuItemAddition
    {
        public Mayo(MenuItem menu) : base(menu) { }
        public override string Description
        {
            get { return MenuItem.Description + ", Mayo"; }

        }
        public override decimal BaseCost { get => MenuItem.BaseCost + 0.00M; }
    }
}
