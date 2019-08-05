using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
   public class Lettuce:MenuItemAddition
    {
        public Lettuce(MenuItem menu) : base(menu) { }
        public override string Description
        {
            get { return MenuItem.Description + ", Lettuce"; }

        }
        public override decimal BaseCost { get => MenuItem.BaseCost + 0.30M; }
    }
}
