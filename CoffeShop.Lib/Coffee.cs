using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public class Coffee:MenuItem
    {
        private string name;

        public Coffee():base("Orginal Bland Coffee", 2.0M)
        {
            name = "Coffe";
        }

        public string Name { get { return name; } set { name = value; } }

       
    }
}
