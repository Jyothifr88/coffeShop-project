using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CoffeShop.Lib
{
    [Serializable()]
    public class Order
    {
        private static uint id;
        private uint orderId;
        private Customer customer;
        private DateTime orderTime;
        private DateTime delTime;
        private DelAddress delAddress;
        private decimal cost;
        private bool isPhoneOrder;
        private List<MenuItem> m_items = new List<MenuItem>();
        private List<OrderItem> o_items = new List<OrderItem>();
        private bool delivered = false; 

        static Order()
        {
            id = 1;
        }

        public Order()
        {
            id++;
            orderId = id;
            customer = new Customer() { Name = "Coffe and sandwitches" };
            orderTime = DateTime.Now;
            delTime = DateTime.Now;
            cost = 0.0M;
            delAddress.Street = "1 King St";
            delAddress.City = "TORONTO";
            delAddress.Province = "ON";
            delAddress.PostalCode = "M1M 1M1";
            delivered = true;

        }
        public Order(Customer cust, bool OrderType)
        {
            id++;
            orderId = id;
            customer = cust;
            cost = 0.0M;
            isPhoneOrder = OrderType;

        }



        public uint OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        [JsonIgnore()]
        public Customer Customer
        {
            get { return customer; }
            set
            {
                if (value == this.customer)

                {
                    customer = value;
                }

                else { Console.WriteLine($"Something went wrong! Customer cannot be changed once assigned"); }
            }

        }
        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        public DateTime DelTime
        {
            get { return delTime; }
            set { delTime = value; }
        }
        public DelAddress DAddress
        {
            get { return delAddress; }
            set { delAddress = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public bool IsPhoneOrder
        {
            get { return isPhoneOrder; }
            set { isPhoneOrder = false; }
        }

        public List<MenuItem> M_Item
        {
            get { return m_items; }
            private set { m_items = value; }
        }
        public List<OrderItem> O_Item
        {
            get { return o_items; }
            private set { o_items = value; }
        }
        public bool Delivered
        {
            get { return delivered; }
            set { delivered = value; }
        }

        public void AddOrderItem(IMenuItem IItem)
        {
            if (IItem != null)
            {
                M_Item.Add((MenuItem)IItem);
                Cost += IItem.BaseCost;
               
            }
        }


        public override string ToString()
        {

            string result = $"\t Order ID: {this.OrderId}\n" +
               $"\t Customer Name: {this.Customer.Name}\n" +
               $"\t Order Time: {this.OrderTime.ToString("H:mm tt")}\n" +
               $"\t Cost: {this.Cost:c}\n" +
               $"\t Delivery Address: {this.DAddress.Street}, {this.DAddress.City}, {this.DAddress.Province}, " +
               $"{this.DAddress.PostalCode}\n" + $"\t Order Time: {this.OrderTime.ToString("yyyy/MM/dd H:mm tt")}\n"+

            $"\t Delivery Time: {this.DelTime.ToString("yyyy/MM/dd H:mm tt")}\n";
            if (Delivered == false)
            {
                result += $"\t Not delivered\n";
            }
            result += $"\t\t Items: ";


            for (int i = 0; i < M_Item.Count; i++)
                if (M_Item[i] != null)
                {
                    result += $"\n{M_Item[i].ToString()}";
                }
            return result;
        }



        public void Deliver()
        {
            Delivered = true;
            DelTime = DateTime.Now;
        }





    }

}

