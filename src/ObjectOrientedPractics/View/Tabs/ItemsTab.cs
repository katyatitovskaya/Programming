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
            Model.Item _currentItem = new Model.Item("New Item", "No info yet", 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                UpdateInfo();
            }
            else
            {
                ClearInfo();
            }
        }

        private void DescriptionRichTextBox_TextChanged(object? sender, EventArgs e)
        {
            DescriptionRichTextBox.BackColor = Color.White;
            int value = ItemsListBox.SelectedIndex;
            if (value != -1)
            {
                try
                {
                    string newInfo = DescriptionRichTextBox.Text;
                    _currentItem.Info = newInfo;
                }
                catch
                {
                    DescriptionRichTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void NameRichTextBox_TextChanged(object? sender, EventArgs e)
        {
            NameRichTextBox.BackColor= Color.White;
            int value = ItemsListBox.SelectedIndex;
            if(value != -1)
            {
                try
                {
                    string newName = NameRichTextBox.Text;
                    _currentItem.Name = newName;
                }
                catch 
                {
                    NameRichTextBox.BackColor = Color.LightPink;
                }
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
                    _currentItem.Price = newCost;
                }
                catch 
                {
                    CostTextBox.BackColor= Color.LightPink;
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
        /*
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int value = ItemsListBox.SelectedIndex;
            _items[value] = _copiedItem;
            ItemsListBox.Items.Clear(); 
            for(int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Name);
            }
            ItemsListBox.Enabled = true;
            AddButton.Enabled = true;
            RemoveButton.Enabled = true;
            
        }*/

       
    }
}
