namespace ContactsApp
{
    public partial class MainForm : Form
    {
        private List<Model.Contact> _contacts = new List<Model.Contact>();
        private Model.Contact _currentContact;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            int value = ContactsListBox.SelectedIndex;
            if (value != -1)
            {
                _contacts.RemoveAt(value);
                ContactsListBox.Items.RemoveAt(value);
                FullNameTextBox.Clear();
                BirthdayDateTimePicker.Value = DateTime.Now;
                PhoneNumberTextBox.Clear();
                VKcomTextBox.Clear();
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ContactsListBox.SelectedIndex!= -1)
            {
                _currentContact = _contacts[ContactsListBox.SelectedIndex];
                FullNameTextBox.Text = _currentContact.FullName;
                BirthdayDateTimePicker.Value = _currentContact.Birthday;
                PhoneNumberTextBox.Text = _currentContact.PhoneNumber;
                VKcomTextBox.Text = _currentContact.Vkcom;
            }
            else
            {
                FullNameTextBox.Clear();
                BirthdayDateTimePicker.Value = DateTime.Now;
                PhoneNumberTextBox.Clear();
                VKcomTextBox.Clear();
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            _currentContact = new Model.Contact(FullNameTextBox.Text,
                PhoneNumberTextBox.Text, BirthdayDateTimePicker.Value, VKcomTextBox.Text);
            _contacts.Add(_currentContact);
            /*for (int i = 0; i < _contacts.Count+1; i++)
            { 
                if ((_contacts[i].FullName.CompareTo(_contacts[i+1].FullName) == 1)
                {
                    var temp = _contacts[i];
                    _contacts[i + 1] = _contacts[i];
                    _contacts[i] = temp;
                }
                
            }*/
            ContactsListBox.Items.Add(_currentContact);
        }
    }
}