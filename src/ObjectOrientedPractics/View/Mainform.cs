using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Drawing.Text;

namespace ObjectOrientedPractics
{
    public partial class Mainform : Form
    {
        /// <summary>
        /// Объект типа <see cref="Model.Store"/>. 
        /// </summary>
        private Store _store = new Store();
        public Mainform()
        {
            InitializeComponent();
            itemsTab.Items = _store.Items;
            customersTab.Customers =_store.Customers;
            cartsTab.Customers = _store.Customers;
            cartsTab.Items = _store.Items;
            ordersTab.Customers = _store.Customers;
            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
            customersTab.CustomersChanged += CustomersTab_CustomersChanged;
            //priorityOrdersTab1.Items = _store.Items;
            //discountsTab1.Items= _store.Items;
        }

        private void CustomersTab_CustomersChanged(object? sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.UpdateOders();
        }

        private void ItemsTab_ItemsChanged(object? sender, EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.UpdateOders();
        }

        /// <summary>
        /// Обновляет данные при смене страницы
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (TabControl.SelectedIndex == 2)
            //{
            //    cartsTab.RefreshData();
            //}
            //if(TabControl.SelectedIndex == 3)
            //{
            //    ordersTab.UpdateOders();
            //}
        }

    }
}