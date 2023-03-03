using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Seasons), typeof(PhoneMakers), typeof(EducationForm), typeof(Colors), typeof(Genre), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex= 0;
            ValuesListBox.SelectedIndex= 0;

            
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
            IntValueTextBox.Text = Convert.ToString(ValuesListBox.SelectedIndex);
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday ChoosenWeekday;
            if(ParseTextBox.Text == null)
            {
                return;
            }
            else
            {
                if(Enum.TryParse(ParseTextBox.Text, out ChoosenWeekday))
                {
                    int EnteredWeekday = (int)ChoosenWeekday;
                    ParseLabel.Text = ($"Это день недели ( {ChoosenWeekday} = {EnteredWeekday} )");
                }
                else
                {
                    ParseLabel.Text = "Нет такого дня недели";
                }
            }
        }

        private void SeasonChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (SeasonChoiceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите время года");
                return; 
            }
            string ChoosenSeason = SeasonChoiceComboBox.SelectedItem.ToString();
            switch (ChoosenSeason)
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
                break;
            }
        }
    }
}