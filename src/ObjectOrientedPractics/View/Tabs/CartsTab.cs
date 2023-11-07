using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы для редактирования и создания заказов. 
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Model.Item"/>.
        /// </summary>
        private List<Model.Item> _items;

        /// <summary>
        /// Список объектов типа <see cref="Model.Customer"/>.
        /// </summary>
        private List<Model.Customer> _customers;

        /// <summary>
        /// Объект типа <see cref="Model.Customer"/>.
        /// </summary>
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

        /// <summary>
        /// Заполняет листбокс с списком товаров в заказе при выборе покупателя. 
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartListBox.Items.Clear();
            if (CustomersComboBox.SelectedIndex != -1)
            {
                Model.Customer currentCustomer = Customers[CustomersComboBox.SelectedIndex];
                DiscountsCheckedListBox.Items.Clear();
                int i = 0;
                foreach(var discount in currentCustomer.Discounts)
                {
                    DiscountsCheckedListBox.Items.Add(discount.Info);
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                    i++;
                }
                UpdateCartListBox();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Обновляет данные в листбоксе с товарами и в комбобоксе с покупателями. 
        /// </summary>
        public void RefreshData()
        {
            ((CurrencyManager)CustomersComboBox.BindingContext[_customers]).Refresh();
            CustomersComboBox.DisplayMember = "FullName";
            CustomersComboBox.ValueMember = "Id";
            ((CurrencyManager)CartItemsListBox.BindingContext[_items]).Refresh();
            CartItemsListBox.DisplayMember = "Name";
            CartItemsListBox.ValueMember = "Id";
            CartListBox.Items.Clear();
            UpdateCartListBox();
        }

        /// <summary>
        /// Обновляет листбокс с списком товаров в заказе выбранного покупателя. 
        /// </summary>
        private void UpdateCartListBox()
        {
            if(Customers.Count!=0)
            {
                CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
                List<Model.Item> currentCustomersItems = CurrentCustomer.Cart.Items;
                List<Model.Item> newCurrentCustomersItems = new List<Model.Item>();
                for (int i = 0; i < currentCustomersItems.Count; i++)
                {
                    if (CartItemsListBox.Items.Contains(currentCustomersItems[i]))
                    {
                        CartListBox.Items.Add(currentCustomersItems[i].Name);
                        newCurrentCustomersItems.Add(currentCustomersItems[i]);
                    }
                }
                for (int i = 0; i < currentCustomersItems.Count; i++)
                {
                    if (newCurrentCustomersItems.
                        Contains(currentCustomersItems[i]) == false)
                    {
                        currentCustomersItems.RemoveAt(i);
                    }
                }
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            
        }
        
        /// <summary>
        /// Создает заказ при нажатии на кнопку. 
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if(CartListBox.Items.Count != 0)
            {
                if (CurrentCustomer.IsPriority == true)
                {
                    CurrentCustomer.Orders.Add(
                        new PriorityOrder(CurrentCustomer.FullName,
                        CurrentCustomer.Address, 
                        CurrentCustomer.Cart.Items, ""));
                }
                else
                {
                    CurrentCustomer.Orders.Add(
                        new Order(CurrentCustomer.FullName,
                        CurrentCustomer.Address,
                        CurrentCustomer.Cart.Items));
                }
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items = new List<Model.Item>();
                AmountLabel.Text = "0";
                UpdateDiscount();
                
            }
        }

        /// <summary>
        /// Удаляет выбранный товар из списка.
        /// </summary>
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
                UpdateDiscount();

            }
        }

        /// <summary>
        /// Очищает корзину. 
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CartListBox.Items.Clear();
                CurrentCustomer.Cart.Items.Clear();
                UpdateDiscount();
            }
        }

        /// <summary>
        /// Добавляет товар в корзину. 
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(CartItemsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add(_items[CartItemsListBox.SelectedIndex]);
                CartListBox.Items.Add(_items[CartItemsListBox.SelectedIndex].Name);
                AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
                UpdateDiscount();
            }
        }

        private void CartItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscount();
        }

        private void UpdateDiscount()
        {
            double discountAmount = 0;
            foreach (var discount in CurrentCustomer.Discounts)
            {
                if(DiscountsCheckedListBox.CheckedItems.Contains(discount))
                {
                    discountAmount += discount.Calculate(CurrentCustomer.Cart.Items);
                }
                
            }
            DiscountAmountLabel.Text = discountAmount.ToString();
        }
    }
}
