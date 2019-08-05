using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CoffeShop.Lib
{
    public class CustomerRepository:RepositoryBase
    {
        private List<Customer> customers = new List<Customer>();
        

        public CustomerRepository() { }
        
        public override List<Customer> Customers
        {
            get { return customers; }
            set { customers = Customers; }
        }


        public void Add(Customer aCustomer)
        {
            if (aCustomer != null)
            {
                Customers.Add(aCustomer);
            }
        }




        public IEnumerable<Customer> CustomersNotDelivered()
        {
            var customersNotDelivered1 = Customers.FindAll(c=>(c.Orders.FindAll(o=>o.Delivered==false).Count())>0);
            return customersNotDelivered1;
        }
        public IEnumerable<Customer> OrderTime(DateTime From,DateTime To)
        {
            var customers = (from cust in Customers
                             from od in cust.Orders
                             where od.OrderTime >= From
                             && od.OrderTime <= DateTime.Now
                             select cust).Distinct();
            return customers;
        }







        public bool TimeOfOrder(Customer aCustomer)
        {
            bool condition = false;
            foreach (Order order in aCustomer.Orders)
            {
                if (order.Delivered == false)
                {
                    condition = true;

                }
            }
            return condition;
        }




    }
}