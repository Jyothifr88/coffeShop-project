using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class SandwichWithEggSalad:MenuItem
    {
        private string name;

        public SandwichWithEggSalad() : base("White bread sandwich with egg salad", 4M)
        {
            name = "SandwichWithEggSalad";
        }

        public string Name { get { return name; } set { name = value; } }

        
    }
}
