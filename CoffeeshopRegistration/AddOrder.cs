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
    public partial class AddOrder : Form
    {
        
        MainForm mainform;
        CoffeShop.Lib.MenuItem menuitem;
        decimal totalcost = 0;
        List<CoffeShop.Lib.MenuItem> menuitems = new List<CoffeShop.Lib.MenuItem>();
        Order order;
        Customer cust;


        public AddOrder(MainForm mainform, Order order,Customer cust)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.order = order;
            this.cust = cust;
        }



        public void Createorder()
        {
            Setmenuitems();
            this.ShowDialog();
        }
         

        private void Setmenuitems()
        {
            Coffee coffee = new Coffee();
            CoffeeDarkRoast coffedarkroast = new CoffeeDarkRoast();
            Tea tea = new Tea();
            SandwichWithBacon sandwichwithBacon = new SandwichWithBacon();
            SandwichWithRoastedBeef sandwichWithRoastedBeef = new SandwichWithRoastedBeef();
            SandwichWithEggSalad sandwichWithEggSalad = new SandwichWithEggSalad();
            listMenu.Items.Add(coffedarkroast);
            listMenu.Items.Add(tea);
            listMenu.Items.Add(sandwichwithBacon);
            listMenu.Items.Add(sandwichWithRoastedBeef);
            listMenu.Items.Add(sandwichWithEggSalad);            
        }
       
            public void btnAddItem_Click(object sender, EventArgs e)
        {

            if (listMenu.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the menu item to add");
                return;
                
            }

            totalcost = 0;

            if (menuitem == null)
            {
                menuitem = listMenu.SelectedItem as CoffeShop.Lib.MenuItem;
                
            }

            menuitems.Add(menuitem);            
            
            foreach (CoffeShop.Lib.MenuItem menuItem in menuitems)
            {
                if (menuItem != null)
                {
                    totalcost = totalcost + menuItem.BaseCost;
                }
            }
            
            txtTotalCost.Text = Convert.ToString(totalcost);

            menuitem = null;

        }

       
       
        private void btnAddAdditions_Click_1(object sender, EventArgs e)
        {
            
            if (menuitem == null)
            {
                menuitem = listMenu.SelectedItem as CoffeShop.Lib.MenuItem;
            }
            
            string text = lbxMenuAdditions.GetItemText(lbxMenuAdditions.SelectedItem);
            
            if (text == "Milk")
            {                
                menuitem = new Milk(menuitem);
            }

            if (text == "Sugar")
            {
                menuitem = new Suggar(menuitem);
            }

            if (text == "Sweetener")
            {
                menuitem = new Sweetener(menuitem);
            }

            if (text == "Cheese")
            {
                menuitem = new Cheese(menuitem);
            }

            if (text == "Lettuce")
            {
                menuitem = new Lettuce(menuitem);
            }

            if (text == "Mayo")
            {
                menuitem = new Mayo(menuitem);
            }

            if (text == "Tomato")
            {
                menuitem = new Tomato(menuitem);
            }

        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            for (int x = 0; x < menuitems.Count; x++)
            {
                order.AddOrderItem(menuitems[x]);
            }
            cust.Orders.Remove(order);
            cust.AddOrder(order);
            mainform.updateorderlist(order,txtTotalCost.Text);
        }
    }
}
