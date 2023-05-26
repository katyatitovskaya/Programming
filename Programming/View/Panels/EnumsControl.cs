using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    ///  Предоставляет методы для вывода данных в листбоксы и текстбокс. 
    /// </summary>
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Seasons),
            typeof(PhoneMakers),
            typeof(EducationForm),
            typeof(Colors),
            typeof(Genre),
            typeof(Weekday) };

            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.SelectedIndex = 0;
            ValuesListBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Заполняет один листбокс в зависимости от выбранного значения в другом.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
        }
        /// <summary>
        /// Выводит индекс выбранного элемента перечисления в текстовое поле. 
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var number = (int)(Enum.Parse((Type)(EnumsListBox.SelectedItem), ValuesListBox.Text));
            IntValueTextBox.Text = number.ToString();
        }
    }
}
