using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class CoffeeDarkRoast:MenuItem
    {
        public CoffeeDarkRoast() : base("Coffe Dark Roast", 2.00M) { }

        public override string Description { get => base.Description; set => base.Description = value; }
        public override decimal BaseCost { get => base.BaseCost; set => base.BaseCost = value; }
    }
}
