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
        private Model.Item _copiedItem;
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Model.Item _currentItem = new Model.Item("New Item", "No info yet", 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = false;
            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                _copiedItem = _currentItem;
                UpdateInfo();
                EditButton.Enabled = true;
                

            }
            else
            {
                ClearInfo();
            }
        }

        private void CostTextBox_TextChanged(object? sender, EventArgs e)
        {
            CostTextBox.BackColor = Color.White;
            int value = ItemsListBox.SelectedIndex;
            if(value != -1)
            {
                try
                {
                    double newCost = Convert.ToDouble(CostTextBox.Text);
                    _copiedItem.Price = newCost;
                    ConfirmButton.Enabled = true;
                }
                catch 
                {
                    CostTextBox.BackColor= Color.LightPink;
                    ConfirmButton.Enabled = false;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int value = ItemsListBox.SelectedIndex;
            if (value!= -1)
            {
                _items.RemoveAt(value);
                ItemsListBox.Items.RemoveAt(value);
                ItemsListBox.SelectedIndex = value-1;

            }
        }
        private void ClearInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameRichTextBox.Clear();
            DescriptionRichTextBox.Clear();
        }
        private void UpdateInfo()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Price.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            DescriptionRichTextBox.Text = _currentItem.Info;
        }

        

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ConfirmButton.Visible = false;
            CancelButton.Visible = false;
            EditButton.Enabled = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ConfirmButton.Visible = false;
            CancelButton.Visible = false;
            EditButton.Enabled = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _copiedItem = Model.Item.CloneItem(_currentItem);
            ConfirmButton.Visible = true;
            CancelButton.Visible = true;
            CostTextBox.ReadOnly = false;
            NameRichTextBox.ReadOnly = false;
            DescriptionRichTextBox.ReadOnly = false;
        }
    }
}
