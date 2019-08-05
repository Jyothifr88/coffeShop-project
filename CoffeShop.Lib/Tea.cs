using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class Tea:MenuItem
    {
        public Tea():base("Tea", 1.80M) { }
       
        public override string Description { get => base.Description; set => base.Description = value; }
        public override decimal BaseCost { get => base.BaseCost; set => base.BaseCost = value; }
    }
}
