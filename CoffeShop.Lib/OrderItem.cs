using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
   public class OrderItem
    {
        private IMenuItem Item;
        
        public OrderItem(IMenuItem m)
        {
            Item = m;
        }
        public IMenuItem Menu

        {
            get { return Item; }
            set { Item = value; }
        }
        

       
    }
}
