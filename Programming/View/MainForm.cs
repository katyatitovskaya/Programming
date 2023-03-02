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
            if(ParseTextBox.Text == null)
            {
                return;
            }
            else
            {

            }
        }

        private void SeasonChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*var seasons = Enum.GetValues(typeof(Seasons));

            foreach (var season in seasons)
            {
                SeasonChoiceComboBox.Items.Add(season);

            }
            SeasonChoiceComboBox.Items.Add(seasons);*/
        }
    }
}