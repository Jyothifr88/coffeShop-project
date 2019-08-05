using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class SandwichWithRoastedBeef:MenuItem
    {
        private string name;

        public SandwichWithRoastedBeef() : base("White bread sandwich with roasted beef", 5.5M)
        {
            name= "SandwichWithRoastedBeef";
        }

        public string Name { get { return name; } set { name = value; } }

        
    }
}
