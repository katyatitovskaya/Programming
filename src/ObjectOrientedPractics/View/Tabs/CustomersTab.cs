﻿using System;
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
        private List<Model.Customer> _customers = new List<Model.Customer>();

        /// <summary>
        /// Объект типа <see cref="Model.Customer"/>.
        /// </summary>
        private Model.Customer _currentCustomer;
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
            Model.Customer _currentCustomer =
                new Model.Customer($"Customer's name {_customers.Count}", "No address info yet");
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(_currentCustomer.FullName);
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
        /// Проверяет и сохраняет значение в текстовом поле. 
        /// </summary>
        private void CustomerAddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = CustomersListBox.SelectedIndex;
            CustomerAddressRichTextBox.BackColor= Color.White;
            try
            {
                string newAddress = CustomerAddressRichTextBox.Text;
                _currentCustomer.Address = newAddress;
            }
            catch
            {
                CustomerAddressRichTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Очищает текстовые поля. 
        /// </summary>
        private void ClearInfo()
        {
            CustomerIDTextBox.Clear();
            CustomerNameTextBox.Clear();
            CustomerAddressRichTextBox.Clear();
        }

        /// <summary>
        /// Обновляет текстовые поля.
        /// </summary>
        private void UpdateInfo()
        {
            CustomerNameTextBox.Text = _currentCustomer.FullName;
            CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            CustomerAddressRichTextBox.Text = _currentCustomer.Address;
        }
    }
}