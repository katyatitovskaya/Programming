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
    /// Предоставляет методы для вывода сообщений в соответсвии с выбранным временем года. 
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        public SeasonsHandleControl()
        {
            InitializeComponent();

            var seasonValues = Enum.GetValues(typeof(Seasons));
            foreach (var season in seasonValues)
            {
                SeasonChoiceComboBox.Items.Add(season);
            }
        }

        /// <summary>
        /// Выводит сообщение в соответствии с выбранным временем года при нажатии на кнопку. 
        /// </summary>
        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonChoiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите время года");
                return;
            }
            string chosenSeason = SeasonChoiceComboBox.SelectedItem.ToString();
            switch (chosenSeason)
            {
                case "Winter":
                    
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    MessageBox.Show("Йеепиии! Весна!!");
                    break;
                case "Summer":
                    
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    MessageBox.Show("Скоро мой день рождения :р");
                    break;
            }
        }
    }
}
