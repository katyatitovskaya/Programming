using ObjectOrientedPractics.Model;
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
        }
    }
}