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
    public partial class WeekadayParsingControl : UserControl
    {
        public WeekadayParsingControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Проверяет вводимое значение на его наличие среди перечисления дней недели
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday choosenWeekday;
            if (ParseTextBox.Text == null)
            {
                return;
            }
            else
            {
                if (Enum.TryParse(ParseTextBox.Text, out choosenWeekday))
                {
                    int enteredWeekday = (int)choosenWeekday;
                    ParseLabel.Text = ($"Это день недели ( {choosenWeekday} = {enteredWeekday + 1} )");
                }
                else
                {
                    ParseLabel.Text = "Нет такого дня недели";
                }
            }
        }
    }
}
