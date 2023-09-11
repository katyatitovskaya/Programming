using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Model.Item> _items = new List<Model.Item>();
        private Model.Item _currentItem; 
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];

            }
            else
            {

            }
        }
        private void ClearInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameRichTextBox.Clear();
            DescriptionRichTextBox.Clear();
        }
    }
}
