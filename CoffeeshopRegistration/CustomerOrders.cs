using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeShop.Lib;

namespace CoffeeshopRegistration
{
    public partial class CustomerOrders : Form
    {
        MainForm mainform;
        //DateTime FromDate;
        //DateTime ToDate;
        public CustomerOrders()
        {
            InitializeComponent();
        }
        public CustomerOrders(MainForm main)
        {
            InitializeComponent();
            mainform = main;
        }

        private void CustomerOrders_Load(object sender, EventArgs e)
        {

        }
        //public CustomerOrders(MainForm mainform,DateTime date1,DateTime date2)
        //{
        //    InitializeComponent();
        //    this.mainform = mainform;
        //    FromDate = date1;
        //    ToDate = date2;
        //}
        public void customersNoOrderDelivered(CustomerRepository repository)
        {
            


            var cust=repository.CustomersNotDelivered();
            foreach (Customer aCustomer in cust)
            {
                lbxcustomerNotDelivered.Items.Add(aCustomer);
            }
            this.ShowDialog();
        }
        public void OrdersWithinTime(CustomerRepository repository,DateTime begin,DateTime end)
        {
            
            var cust = repository.OrderTime(begin,end);

            foreach (Customer aCustomer in cust)
            {
                lbxcustomerNotDelivered.Items.Add(aCustomer);
            }
            this.ShowDialog();
        }

        private void lbxcustomerNotDelivered_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxcustomerNotDelivered.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the customer to see the order details");
                return;
            }
            lbxOrderlist.Items.Clear();
            Customer cust = lbxcustomerNotDelivered.SelectedItem as Customer;
            foreach(Order od in cust.Orders)
            {
                lbxOrderlist.Items.Add(od.ToString());
            }
            
        }

        

        
        
    }
}
