﻿using System;
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
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder priorityOrder = new PriorityOrder();
        

        private List<Model.Item> _items;
        public List<Model.Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }
        public PriorityOrdersTab()
        {
            InitializeComponent();
            string[] deliveryTime = new string[6] { "9:00-11:00", 
                "11:00-13:00","13:00-15:00",
                "15:00-17:00","17:00-19:00",
                "19:00-21:00" };
            DeliveryTimeComboBox.Items.AddRange(deliveryTime);

            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                StatusComboBox.Items.Add(status);
            }
            var rand = new Random();
            priorityOrder.Address = new Model.Address(rand.Next(99999, 999999),
                "Country", "City", "Street", "Building", "Apartment");
            IDTextBox.Text = priorityOrder.Id.ToString();
            CreatedTextBox.Text = priorityOrder.Date;
            addressControl.Address = priorityOrder.Address;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priorityOrder.OrderStatus = (OrderStatus)(StatusComboBox.SelectedIndex);
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            OrderItemsListBox.Items.Clear();
            var rand = new Random();
            int value = rand.Next(0, Items.Count);
            priorityOrder.Items.Add(Items[value]);
            for (int i = 0; i < priorityOrder.Items.Count; i++)
            {
                OrderItemsListBox.Items.Add(priorityOrder.Items[i].Name);
            }
            AmountLabel.Text = priorityOrder.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int value = OrderItemsListBox.SelectedIndex;
            if (value!= -1)
            {
                priorityOrder.Items.RemoveAt(value);
                
                if (value == 0)
                {
                    value = priorityOrder.Items.Count-1;
                }
                else
                {
                    value--;
                }
                
                OrderItemsListBox.Items.Clear();
                for (int i = 0; i < priorityOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(priorityOrder.Items[i].Name);
                }
                OrderItemsListBox.SelectedIndex = value;
                AmountLabel.Text = priorityOrder.Amount.ToString();
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            priorityOrder.Address = null;
            priorityOrder = null;
            OrderItemsListBox.Items.Clear();
            PriorityOrder newPriorityOrder = new PriorityOrder();
            priorityOrder = newPriorityOrder;
            AmountLabel.Text = priorityOrder.Amount.ToString();
            IDTextBox.Text = priorityOrder.Id.ToString();
            CreatedTextBox.Text = priorityOrder.Date;
            var rand = new Random();
            priorityOrder.Address = new Model.Address(rand.Next(99999, 999999),
                "Country", "City", "Street", "Building", "Apartment");
            addressControl.Address = priorityOrder.Address;
        }
    }
}
