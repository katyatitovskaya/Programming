using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет методы для добавления и удаления покупателей. 
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Model.Customer"/>. 
        /// </summary>
        private List<Model.Customer> _customers;

        public List<Model.Customer> Customers
        {
            get=> _customers;
            set
            {
                _customers = value;
            }
        }

        public event EventHandler<EventArgs> CustomersChanged;

        /// <summary>
        /// Объект типа <see cref="Model.Customer"/>.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Обновляет данные в текстовых полях при смене выбранного элемента.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = _customers[CustomersListBox.SelectedIndex];
                UpdateInfo();
            }
            else
            {
                ClearInfo();
            }
        }

        /// <summary>
        /// Добавляет покупателя при нажатии на кнопку. 
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e) 
        {
            Customer _currentCustomer =
                new Customer($"Customer's name {_customers.Count}");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            _currentCustomer.Address.AddressChanged += Address_AddressChanged;
            CustomersChanged?.Invoke(sender, EventArgs.Empty);
        }

        private void Address_AddressChanged(object sender, EventArgs e)
        {
            string message = "Адрес был изменен.";
            MessageBox.Show(message);
        }

        /// <summary>
        /// Удаляет выбранный объект из списка при нажатии на кнопку. 
        /// </summary>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int value = CustomersListBox.SelectedIndex;
            if(value != -1) 
            {
                _customers.RemoveAt(value);
                CustomersListBox.Items.RemoveAt(value);
                CustomersListBox.SelectedIndex = value - 1;
                CustomersChanged?.Invoke(sender, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Проверяет и сохраняет значение в текстовом поле. 
        /// </summary>
        private void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            CustomerNameTextBox.BackColor= Color.White;
            int value = CustomersListBox.SelectedIndex;
            if (CustomerNameTextBox.Focused)
            {
                if(value != -1)
                {
                    try
                    {
                        string newName = CustomerNameTextBox.Text;
                        _currentCustomer.FullName = newName;
                        int currentSelection = CustomerNameTextBox.SelectionStart;
                        CustomersListBox.Items[value] = _currentCustomer.FullName;
                        CustomerNameTextBox.SelectionStart = currentSelection;
                    }
                    catch 
                    {
                        CustomerNameTextBox.BackColor = Color.LightPink;
                    }
                }
            }
        }

      
        /// <summary>
        /// Очищает текстовые поля. 
        /// </summary>
        private void ClearInfo()
        {
            CustomerIDTextBox.Clear();
            CustomerNameTextBox.Clear();
            AddressControl.Address = null;
            DiscountsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновляет текстовые поля.
        /// </summary>
        private void UpdateInfo()
        {
            CustomerNameTextBox.Text = _currentCustomer.FullName;
            CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            AddressControl.Address = _currentCustomer.Address;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.Items.Clear();
            foreach(var discount in _currentCustomer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Сохраняет, является ли покупатель приоритетным
        /// </summary>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                if (IsPriorityCheckBox.Checked)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }
            
        }

        /// <summary>
        /// Вызывает всплывающее окно для добавления скидки.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if(CustomersListBox.SelectedIndex != -1)
            {
                AddDiscount addDiscountForm = new AddDiscount();
                addDiscountForm.CurrentCustomer = _currentCustomer;
                var dialogResult = addDiscountForm.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    DiscountsListBox.Items.Clear();
                    foreach (var discount in _currentCustomer.Discounts)
                    {
                        DiscountsListBox.Items.Add(discount.Info);
                    }
                }
                CustomersChanged?.Invoke(sender, e);
            }
        }

        /// <summary>
        /// Удаляет выбранную скидку. 
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int value = DiscountsListBox.SelectedIndex;
            if(value!= -1 && value != 0)
            {
                _currentCustomer.Discounts.RemoveAt(value);
                UpdateInfo();
                CustomersChanged?.Invoke(sender, e);
            }

        }
    }
}
 