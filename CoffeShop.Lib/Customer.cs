using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CoffeShop.Lib
{
    [Serializable()]
    public class Customer
    {
        private static uint id;
        private uint customerId;
        private string name;
        private Address address;
        private ulong phone;
        List<Order> order = new List<Order>();


        public Customer() { }

        public Customer(string CustName, uint PhoneNo, Address Address)
        {

            ++id;
            customerId = id;
            name = CustName;
            phone = PhoneNo;
            address = Address;
            

        }
        public Customer(string CustName, uint PhoneNo, string SHOPADDRESS)
        {
            id++;
            customerId = id;
            name = CustName;
            phone = PhoneNo;
            address.Street = "1 King St";
            address.City = "Toronto,";
            address.Province = "ON";
            address.PostalCode = " M1M 1M1";
        }


        public uint CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public ulong Phone
        {
            get { return phone; }
            set
            {
                    phone = value;
            }
        }
        public List<Order> Orders
        {
            get { return order; }
            private set { order = value; }
        }



        public override string ToString()
        {
            string result = $"Customer Id: {CustomerId}, Name: {Name},\n \t  Address: {Address.Street},{Address.City},{Address.Province}{Address.PostalCode}, Phone No: {Phone}, \n\t Orders: ";

            for (int i = 0; i < Orders.Count; i++)
                if (Orders[i] != null)
                {
                    result += $"\n{Orders[i].ToString()}";
                }
            return result;
        }

        public Order CreatePhoneOrder(Address custAdd)
        {
            Order order = new Order(this, true) { OrderTime = DateTime.Now 
        };
            order.Customer.Name = this.Name;
            order.DAddress = new DelAddress() { Street = custAdd.Street, City = custAdd.City, Province = custAdd.Province, PostalCode = custAdd.PostalCode };
            order.Delivered = false;
            AddOrder(order);

            return order;
        }


        public Order AddOrder(Order od)
        {
            if (od != null)
            {
                Orders.Add(od);
            }
            return od;
        }


    }
}

