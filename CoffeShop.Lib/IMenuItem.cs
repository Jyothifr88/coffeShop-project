using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoffeShop.Lib
{
    public interface IMenuItem
    {
        [JsonProperty]
         string Description { get; set; }
        [JsonProperty]
         decimal BaseCost { get; set; }


    }
}
