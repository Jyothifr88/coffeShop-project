using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class Sweetener:MenuItemAddition
    {
        public Sweetener(MenuItem menu) : base(menu) { }
        public override string Description
        {
            get { return MenuItem.Description + ", Sweetener"; }

        }
        public override decimal BaseCost { get => MenuItem.BaseCost + 0.06M; }
    }
}
