using System.DirectoryServices;
using System.Drawing.Text;
using System.Windows.Forms;
using Programming.Model.Class;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Programming.Model.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Programming.View
{
    public partial class MainForm : Form
    {
       
        public MainForm() 
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
           

            var seasonValues = Enum.GetValues(typeof(Seasons));
            foreach (var season in seasonValues)
            {
                SeasonChoiceComboBox.Items.Add(season);
            }
            
        }

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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var number = (int)(Enum.Parse((Type)(EnumsListBox.SelectedItem), ValuesListBox.Text));
            IntValueTextBox.Text = number.ToString();
        }

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
                    SeasonHandleGroupBox.BackColor = Color.Transparent;
                    groupBoxEnums.BackColor = Color.Transparent;
                    WeekdayParsingGroupBox.BackColor = Color.Transparent;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    SeasonHandleGroupBox.BackColor = Color.YellowGreen;
                    groupBoxEnums.BackColor = Color.YellowGreen;
                    WeekdayParsingGroupBox.BackColor = Color.YellowGreen;
                    break;
                case "Summer":
                    SeasonHandleGroupBox.BackColor = Color.Transparent;
                    groupBoxEnums.BackColor = Color.Transparent;
                    WeekdayParsingGroupBox.BackColor = Color.Transparent;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    SeasonChoiceResultLabel.Text = "";
                    SeasonHandleGroupBox.BackColor = Color.Orange;
                    groupBoxEnums.BackColor = Color.Orange;
                    WeekdayParsingGroupBox.BackColor = Color.Orange;
                    break;
            }
        }
    }
}