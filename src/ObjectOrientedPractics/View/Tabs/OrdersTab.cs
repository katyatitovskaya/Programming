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
    public partial class OrdersTab : UserControl
    {
        private List<Model.Customer> _customers;
        private List<Model.Order> _orders = new List<Order>();
        public List<Model.Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }

        
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Order currentOrder = _orders[dataGridView1.CurrentCell.RowIndex];
            addressControl.Address = currentOrder.Address;
            IDTextBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            CreatedTextBox.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            StatusComboBox.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value;
            for (int i = 0; i < currentOrder.Items.Count; i++)
            {
                OrderItemsListBox.Items.Add(currentOrder.Items[i].Name);
            }
            AmountLabel.Text = currentOrder.Amount.ToString();

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order currentOrder = _orders[dataGridView1.CurrentCell.RowIndex];
            currentOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
        }
    }
}
