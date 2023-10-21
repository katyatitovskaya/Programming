using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private List<Model.Item> _items;
        private List<Model.Customer> _customers;
        private Model.Customer CurrentCustomer = new Model.Customer();
        public List<Model.Item> Items
        {
            get => _items;
            set
            {   

                _items= value;
                CartItemsListBox.DataSource = _items;
            }
        }

        public List<Model.Customer> Customers
        {
            get => _customers;
            set
            {
                _customers= value;
                CustomersComboBox.DataSource = _customers;
            }
        }
        

        public CartsTab()
        {
            InitializeComponent();
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
                List<Model.Item> currentCustomersItems = CurrentCustomer.Cart.Items;  
                for(int i=0; i<currentCustomersItems.Count; i++)
                {
                    CartListBox.Items.Add(currentCustomersItems[i].Name);
                }
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        public void RefreshData()
        {
            ((CurrencyManager)CustomersComboBox.BindingContext[_customers]).Refresh();
            CustomersComboBox.DisplayMember = "FullName";
            CustomersComboBox.ValueMember = "Id";
            ((CurrencyManager)CartItemsListBox.BindingContext[_items]).Refresh();
            CartItemsListBox.DisplayMember = "Name";
            CartItemsListBox.ValueMember = "Id";

        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if(CartListBox.Items.Count != 0)
            {
                CurrentCustomer.Orders.Add(
                    new Model.Order(CurrentCustomer.Address, 
                    CurrentCustomer.Cart.Items));
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if(CustomersComboBox.SelectedIndex != -1 && CartListBox.SelectedIndex != -1)
            {
                int value = CartListBox.SelectedIndex;
                CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
                CurrentCustomer.Cart.Items.RemoveAt(value);
                CartListBox.Items.RemoveAt(value);
                CartListBox.SelectedIndex = value - 1;
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(CartItemsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(_items[CartItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(_items[CartItemsListBox.SelectedIndex].Name);
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }

    }
}
