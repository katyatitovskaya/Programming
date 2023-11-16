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
using ObjectOrientedPractics.Services;

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
        private List<Model.Item> _items;

        public List<Model.Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

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
            string[] sortTypes = new string[3]
            {"Cost (Ascending)", "Cost (Descending)", "Name"};
            SortingComboBox.Items.AddRange(sortTypes);
            SortingComboBox.SelectedIndex = 2;
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
                //_currentItem = _items[ItemsListBox.SelectedIndex];
                UpdateInfo(Items);
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
                        SortItemsInListBox();
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
                if(CostTextBox.Focused)
                {
                    try
                    {
                        double newCost = Convert.ToDouble(CostTextBox.Text);
                        _currentItem.Price = newCost;
                        int currentSelection = CostTextBox.SelectionStart; 
                        SortItemsInListBox();
                        CostTextBox.SelectionStart = currentSelection;
                    }
                    catch
                    {
                        CostTextBox.BackColor = Color.LightPink;
                    }
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
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет текстовые поля. 
        /// </summary>
        private void UpdateInfo(List<Model.Item> items)
        {
            _currentItem = items[ItemsListBox.SelectedIndex];
            IDTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Price.ToString();
            NameRichTextBox.Text = _currentItem.Name;
            DescriptionRichTextBox.Text = _currentItem.Info;
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        /// <summary>
        /// Сохраняет выбранную категорию.
        /// </summary>
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
            }
        }

        public bool AssertString(Model.Item item, object str)
        {
            if (item.Name.Contains((string)str))
            {
                return true;
            }
            return false;
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if(FindTextBox.Text!=null && Items!=null)
            {
                Model.Item selectedItem = _currentItem;
                foreach (Model.Item item in Items)
                {
                    if (item.Name == (string)ItemsListBox.SelectedItem)
                    {
                        selectedItem = item;
                    }
                }
                List<Model.Item> filteredItems = 
                    DataTools.Filter(Items, AssertString, FindTextBox.Text);
                ItemsListBox.Items.Clear();
                foreach(Model.Item item in filteredItems)
                {
                    ItemsListBox.Items.Add(item.Name);
                }
                if(filteredItems.Contains(selectedItem))
                {
                    ItemsListBox.SelectedIndex = filteredItems.IndexOf(selectedItem);
                    UpdateInfo(filteredItems);
                }
                else
                {
                    ClearInfo();
                }
               
            }
        }

        public void SortItemsInListBox()
        {
            if (Items == null) return;
            Model.Item selectedItem = _currentItem;
            foreach (Model.Item item in Items)
            {
                if (item.Name == (string)ItemsListBox.SelectedItem)
                {
                    selectedItem = item;
                }
            }
            List<Model.Item> sortedItems = new List<Model.Item>();
            if (SortingComboBox.SelectedIndex == 0)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostAscending);
            }
            if (SortingComboBox.SelectedIndex == 1)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortCostDescending);
            }
            if (SortingComboBox.SelectedIndex == 2)
            {
                sortedItems = DataTools.Sort(Items, DataTools.SortName);
            }
            ItemsListBox.Items.Clear();
            foreach (Model.Item item in sortedItems)
            {
                ItemsListBox.Items.Add(item.Name);
            }
            ItemsListBox.SelectedIndex = sortedItems.IndexOf(selectedItem);
        }
        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SortingComboBox.SelectedIndex != -1 && Items!=null)
            {
                SortItemsInListBox();
            }
        }
    }
}
