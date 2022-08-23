using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem10Chapter10
{
    public partial class Form1 : Form
    {
        double totalOrderCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Continue1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(menu); 
        }

        private void AddOrRemoveItemDrinks(object sender, EventArgs e) 
        {            
            OrderTotal.BeginUpdate();

            double drinkCost = 2.5;
            OrderTotal.Items.Add(Drinks.SelectedItem + ": $2.5");
            OrderTotal.EndUpdate();

            IncrementPrice(drinkCost);
        }

        private void AddOrRemoveItemPizza(object sender, EventArgs e)
        {
            OrderTotal.BeginUpdate();

            double small = 6.0;
            double medium = 10.0;
            double large = 16.0; 

            if (PizzaSize.SelectedItem == "Small") 
            {
                IncrementPrice(small);

                OrderTotal.Items.Add(PizzaSize.SelectedItem + ": $6.0");
            }
            else if (PizzaSize.SelectedItem == "Medium")
            {
                IncrementPrice(medium);

                OrderTotal.Items.Add(PizzaSize.SelectedItem + ": $10.0");
            }
            else if (PizzaSize.SelectedItem == "Large")
            {
                IncrementPrice(large);

                OrderTotal.Items.Add(PizzaSize.SelectedItem + ": $16.0");
            }

            OrderTotal.EndUpdate();
        }

        private void IncrementPrice(double itemPrice) 
        {
            totalOrderCost += itemPrice;


            totalLabel.Text = "Total:  $" + Convert.ToString(totalOrderCost);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Drinks.ClearSelected();
            PizzaSauce.ClearSelected();
            PizzaSize.ClearSelected();
            PizzaToppings.ClearSelected();
            otherfood.ClearSelected();
            OrderTotal.Items.Clear();
            totalLabel.Text = "Total: $0.0";
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Checkout);
            Total.Items.AddRange(OrderTotal.Items);
            OrderFinalTotal.Text = totalLabel.Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(menu);
        }

        private void orderConfirm_Click(object sender, EventArgs e)
        {
            //add the code here to display 
            //order info to a message box 
        }
    }
}
