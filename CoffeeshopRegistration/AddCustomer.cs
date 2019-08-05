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
    public partial class AddCustomer : Form
    {
        MainForm mainform;
        public AddCustomer(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }
               
        public void Addcustomer()
        {
            this.ShowDialog();
        }

        private void btnAdd_customer_Click(object sender, EventArgs e)
        {
            Address address;
            
            address.Street = txtStreet.Text;
            address.Province = txtProvince.Text;
            address.PostalCode = txtPostalCode.Text;
            address.City = txtCity.Text;
            Customer customer = new Customer(txtName.Text, Convert.ToUInt32(txtPhoneno.Text), address);
            mainform.updatelist(customer);
            this.Close();
            mainform.Show();
            
        }

        public void editcustomer(Customer cust)
        {
            txtName.Text = cust.Name;
            txtStreet.Text = cust.Address.Street;
            txtProvince.Text = cust.Address.Province;
            txtPostalCode.Text = cust.Address.PostalCode;
            txtCity.Text = cust.Address.City;
            txtPhoneno.Text = Convert.ToString(cust.Phone);
            this.ShowDialog();
            
        }

        //private void buttonUpdate_Click(object sender, EventArgs e)
        //{
        //    Address address;

        //    address.Street = txtStreet.Text;
        //    address.Province = txtProvince.Text;
        //    address.PostalCode = txtPostalCode.Text;
        //    address.City = txtCity.Text;
        //    Customer customer = new Customer(txtName.Text, Convert.ToUInt32(txtPhoneno.Text), address);
        //    mainform.updatelist(customer);
        //    this.Close();
        //    mainform.Show();
        //}
    }
}
