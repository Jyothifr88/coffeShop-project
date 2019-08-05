using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class SandwichWithBacon:MenuItem
    {
        private string name;

        public SandwichWithBacon() : base("White bread sandwich with bacon", 5.0M)
        {
            name= "SandwichWithBacon";
        }

        public string Name { get { return name; } set { name = value; } }

        
    }
}
