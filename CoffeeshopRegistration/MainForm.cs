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
    public partial class MainForm : Form
    {
        int index = -1;
        CustomerRepository custrep  = new CustomerRepository();
        Order order;
        public MainForm()
        {
            InitializeComponent();
            Customer internalCustomer = new Customer("Coffee and sandwiches", 0, Address.SHOP_ADDRESS);
            CustomersList.Items.Add(internalCustomer);                    

        }

        

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            index = -1;
            AddCustomer addcustomer = new AddCustomer(this);
            this.Hide();
            addcustomer.Addcustomer();
           
        }

              
        public void updatelist(Object cust)
        {
            if (index >= 0)
            {
                CustomersList.Items.RemoveAt(index);
                CustomersList.Items.Insert(index, cust);
            }
            else
            {
                CustomersList.Items.Add(cust);
            }
        }

        public void updateorderlist(Order order,string TotalCost)
        {

            if (order.M_Item.Count > 0)

            {
                listOrder.Items.Clear();

                for (int i = 0; i < order.M_Item.Count; i++)
            {
                if (order.M_Item[i] != null)
                {
                    listOrder.Items.Add(order.M_Item[i].Description + ' ' +order.M_Item[i].BaseCost );

                }
            }
                
                listOrder.Items.Add("Total Cost " + TotalCost);

                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CustomersList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the customer to edit");
                return;
                
            }
            index = CustomersList.SelectedIndex;
            AddCustomer addcustomer = new AddCustomer(this);
            addcustomer.editcustomer(CustomersList.SelectedItem as Customer);
            

        }

        
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            if (CustomersList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the customer to add Order");
                return;
;
            }

            Customer cust = CustomersList.SelectedItem as Customer;

            if (CustomersList.SelectedIndex == 0)
            {
                order = new Order();
            }
            else
            {
                
                order = cust.CreatePhoneOrder(cust.Address);
             }
            AddOrder addorder = new AddOrder(this, order,cust);

            addorder.Createorder();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (CustomersList.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the customer to save");
                return;
                
            }
            custrep.Customers.Remove(CustomersList.SelectedItem as Customer);
            custrep.Add(CustomersList.SelectedItem as Customer);
            custrep.Save("Customers.json");
            MessageBox.Show("Customer saved successfully");
            
        }

        private void btn_customersNotDelivered_Click(object sender, EventArgs e)
        {
            CustomerOrders custOrder = new CustomerOrders(this);
           // this.Hide();
            custOrder.customersNoOrderDelivered(custrep);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnOrdersTime_Click(object sender, EventArgs e)
        {
            DateTime FromDate = this.dtpFrom.Value;
            DateTime ToDate = this.dtpTo.Value;

            //DateTime FromDate = DateTime.Parse(txtFrom.Text);
            //DateTime ToDate = DateTime.Parse(txtTo.Text);

            CustomerOrders custOrder = new CustomerOrders(this);
            this.Hide();
            custOrder.OrdersWithinTime(custrep,FromDate,ToDate);

            //var cust = custrep.OrderTime(FromDate,ToDate);

            //foreach (Customer aCustomer in cust)
            //{
            //    lbxcustomerNotDelivered.Items.Add(aCustomer);
            //}
            //this.ShowDialog();

        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
