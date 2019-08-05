using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeShop.Lib
{
    [Serializable()]
    public class MenuItem:IMenuItem
    {
       
        protected string description;
        protected decimal baseCost;

        public MenuItem()
        {

        }
        public MenuItem( string description, decimal cost)
        {
           
            this.description = description;
            baseCost = cost;
        }

        
        public virtual string Description
        {
            get { return description; }
            set { description = value; }
        }
        public virtual decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public override string ToString()
        {
            return $"Menu item:\t Description: {Description}\n \t Base cost: {BaseCost:c}";
        }
    }
}
