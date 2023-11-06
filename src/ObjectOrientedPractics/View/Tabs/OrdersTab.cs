using ObjectOrientedPractics.Model.Orders;
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
    /// <summary>
    /// Предоставляет методы для отображения информации о заказах.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Model.Customer"/>. 
        /// </summary>
        private List<Model.Customer> _customers;

        /// <summary>
        /// Список объектов типа <see cref="Model.Orders.Order"/>.
        /// </summary>
        private List<Order> _orders = new List<Order>();
        public List<Model.Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }
        /// <summary>
        /// Объект типа <see cref="Order"/>
        /// </summary>
        Order currentOrder;

        /// <summary>
        /// Объект типа <see cref="PriorityOrder"/>
        /// </summary>
        PriorityOrder currentPriorityOrder;
        
        public OrdersTab()
        {
            InitializeComponent();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                StatusComboBox.Items.Add(status);
            }

            string[] deliveryTime = new string[6] { "9:00-11:00",
                "11:00-13:00","13:00-15:00",
                "15:00-17:00","17:00-19:00",
                "19:00-21:00" };
            DeliveryTimeComboBox.Items.AddRange(deliveryTime);
            DeliveryTimeComboBox.SelectedIndex = -1;
            PriorityOptionsPanel.Visible = false;

        }
        
        private void OrdersTab_Load(object sender, EventArgs e)
        {

        }

        
        /// <summary>
        /// Обновляет данные в таблице. 
        /// </summary>
        public void UpdateOders()
        {
            _orders.Clear();
            if (_customers == null) return;
            foreach(var customer in _customers)
            {
                foreach(var order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = _orders;
        }

        /// <summary>
        /// Обновляет данные в текстовых полях при выборе заказа в таблице. 
        /// </summary>
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Order checkedOrder = _orders[DataGridView.CurrentCell.RowIndex];
            if(checkedOrder.GetType() == typeof(PriorityOrder))
            {
                currentOrder = checkedOrder;
                currentPriorityOrder = (PriorityOrder)checkedOrder;
                PriorityOptionsPanel.Visible = true;
                addressControl.Address = currentPriorityOrder.Address;
                IDTextBox.Text = Convert.ToString(DataGridView.CurrentRow.Cells[0].Value);
                CreatedTextBox.Text = Convert.ToString(DataGridView.CurrentRow.Cells[1].Value);
                StatusComboBox.SelectedItem = DataGridView.CurrentRow.Cells[5].Value;
                OrderItemsListBox.Items.Clear();
                for (int i = 0; i < currentPriorityOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(currentPriorityOrder.Items[i].Name);
                }
                AmountLabel.Text = currentPriorityOrder.Amount.ToString();
                DeliveryTimeComboBox.SelectedItem = 
                    currentPriorityOrder.DeliveryTime.ToString();
            }
            else
            {
                currentOrder = checkedOrder;
                currentPriorityOrder = null;
                PriorityOptionsPanel.Visible = false;
                addressControl.Address = currentOrder.Address;
                IDTextBox.Text = Convert.ToString(DataGridView.CurrentRow.Cells[0].Value);
                CreatedTextBox.Text = Convert.ToString(DataGridView.CurrentRow.Cells[1].Value);
                StatusComboBox.SelectedItem = DataGridView.CurrentRow.Cells[5].Value;
                OrderItemsListBox.Items.Clear();
                for (int i = 0; i < currentOrder.Items.Count; i++)
                {
                    OrderItemsListBox.Items.Add(currentOrder.Items[i].Name);
                }
                AmountLabel.Text = currentOrder.Amount.ToString();
            }
        }

        /// <summary>
        /// Сохраняет измененный статус заказа. 
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentOrder = _orders[DataGridView.CurrentCell.RowIndex];
            currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Сохраняет измененное время доставки заказа.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPriorityOrder.DeliveryTime = DeliveryTimeComboBox.SelectedItem.ToString();
        }
    }
}
