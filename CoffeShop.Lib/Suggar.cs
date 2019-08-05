using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class Suggar:MenuItemAddition
    {
        //public Sugar() { }
        public Suggar(MenuItem menu) : base(menu) { }
        public override string Description
        {
            get { return MenuItem.Description+", Sugar"; }
            
        }
        public override decimal BaseCost { get => MenuItem.BaseCost+ 0.05M;  }
    }
}
