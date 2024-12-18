using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Drawing.Text;

namespace ObjectOrientedPractics
{
    public partial class Mainform : Form
    {
        /// <summary>
        /// ������ ���� <see cref="Model.Store"/>. 
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
            //priorityOrdersTab1.Items = _store.Items;
            //discountsTab1.Items= _store.Items;
        }

        /// <summary>
        /// ��������� ������ ��� ����� ��������
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                cartsTab.RefreshData();
            }
            if(TabControl.SelectedIndex == 3)
            {
                ordersTab.UpdateOders();
            }
        }

    }
}