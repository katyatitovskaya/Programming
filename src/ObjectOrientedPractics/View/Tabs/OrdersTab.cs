using ObjectOrientedPractics.Model;
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
        /// Список объектов типа <see cref="Model.Order"/>.
        /// </summary>
        private List<Model.Order> _orders = new List<Order>();
        public List<Model.Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }

        //Model.Order currentOrder = new Model.Order();
        //Model.PriorityOrder currentPriorityOrder = new Model.PriorityOrder();
        
        public OrdersTab()
        {
            InitializeComponent();
            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                StatusComboBox.Items.Add(status);
            }
            
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
            
            Order currentOrder = _orders[DataGridView.CurrentCell.RowIndex];
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

        /// <summary>
        /// Сохраняет измененный статус заказа. 
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order currentOrder = _orders[DataGridView.CurrentCell.RowIndex];
            currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
    }
}
