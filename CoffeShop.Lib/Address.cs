using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Lib
{
    public struct Address
    {
        
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;
        public static string SHOP_ADDRESS; 
        
        
        public Address( string street, string city, string province,string postalCode)
        {
            
            Street = street;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }

    }
}