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
    /// <summary>
    /// Предоставляет метододы для добавления, удаления и изменения данных о товарах. 
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список объектов типа <see cref="Model.Item"/>.
        /// </summary>
        private List<Model.Item> _items = new List<Model.Item>();

        /// <summary>
        /// Обеъект типа <see cref="Model.Item"/>.
        /// </summary>
        private Model.Item _currentItem;
        public ItemsTab()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category)); 
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// При нажатии на кнопку добавляет товар в список. 
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        { 
            Model.Item _currentItem = new Model.Item($"New Item {_items.Count}", "No info yet", 0, 0);
            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);
        }

        /// <summary>
        /// Обновляет информацию в текстовых полях при смене выбранного элемента. 
        /// </summary>
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

        /// <summary>
        /// Проверяет и сохраняет значение текстового поля при его изменении. 
        /// </summary>
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

        /// <summary>
        /// Проверяет и сохраняет значение текстового поля при его изменении. 
        /// </summary>
        private void NameRichTextBox_TextChanged(object? sender, EventArgs e)
        {
            NameRichTextBox.BackColor= Color.White;
            int value = ItemsListBox.SelectedIndex;
            if (NameRichTextBox.Focused)
            {
                if (value != -1)
                {
                    try
                    {
                        string newName = NameRichTextBox.Text;
                        _currentItem.Name = newName;
                        int currentSelection = NameRichTextBox.SelectionStart;
                        ItemsListBox.Items[value] = _currentItem.Name;
                        NameRichTextBox.SelectionStart = currentSelection;
                    }
                    catch
                    {
                        NameRichTextBox.BackColor = Color.LightPink;
                    }
                }
            }
           
        }

        /// <summary>
        /// Проверяет и сохраняет значение текстового поля при его изменении. 
        /// </summary>
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

        /// <summary>
        /// Удаляет выбранный элемент при нажатии на кнопку. 
        /// </summary>
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

        /// <summary>
        /// Очищает текстовые поля. 
        /// </summary>
        private void ClearInfo()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameRichTextBox.Clear();
            DescriptionRichTextBox.Clear();
            //CategoryComboBox.Items.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет текстовые поля. 
        /// </summary>
        private void UpdateInfo()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Price.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            DescriptionRichTextBox.Text = _currentItem.Info;
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ItemsListBox.SelectedIndex!= -1)
            {
                Category newCategory = (Category)(CategoryComboBox.SelectedItem);
                _currentItem.Category = newCategory;
            }
            else
            {
                CategoryComboBox.SelectedIndex = -1;
                //CategoryComboBox.Items.Clear();
            }
        }
    }
}
