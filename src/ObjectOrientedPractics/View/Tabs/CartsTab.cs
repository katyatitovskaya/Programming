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

    }
}
