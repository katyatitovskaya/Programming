namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Seasons), typeof(PhoneMakers), typeof(EducationForm), typeof(Colors), typeof(Genre), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();    
            foreach ( var enumValue in enumValues )
            {
                ValuesListBox.Items.Add( enumValue );
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = Convert.ToString(ValuesListBox.SelectedIndex);
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}