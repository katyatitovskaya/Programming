using ContactsApp.Model;
using System;
using System.Text.Json;

namespace ContactsApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ �������� ���� <see cref="Contact"/>.  
        /// </summary>
        private List<Model.Contact> _contacts = new List<Model.Contact>();

        /// <summary>
        /// ������ ���� <see cref="Contact"/>. 
        /// </summary>
        private Model.Contact _currentContact;

        /// <summary>
        /// ������ ���� <see cref="Contact"/> 
        /// ��� ����������� � ���� ������ ������� ������� �� ����� ��� ���������.
        /// </summary>
        private Model.Contact _copiedContact;

        /// <summary>
        /// ���� � ����� <see cref="_fileName"/>. 
        /// </summary>
        private string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.
            ApplicationData) + "\\ContactsApp";

        /// <summary>
        /// ����, �������� ������� ������ <see cref="Contact"/> 
        /// </summary>
        private string _fileName = "Contacts.json";
        public MainForm()
        {
            InitializeComponent();

            _contacts = Model.ProjectSerializer.LoadFromFile(_directoryPath, _fileName);
            for(int i = 0; i< _contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_contacts[i].FullName);
            }
        }
        
        /// <summary>
        /// ������� ��������� ������� �� ������ � ���������.
        /// </summary>
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            int value = ContactsListBox.SelectedIndex;
            if (value != -1)
            {
                _contacts.RemoveAt(value);
                ContactsListBox.Items.RemoveAt(value);
                ClearInfo();
                ContactsListBox.SelectedIndex = value - 1;
                ProjectSerializer.SaveToFile(_contacts, _directoryPath, _fileName);
            }
        }

        /// <summary>
        /// ��������� ������ � ��������� ����� ��� ����� ���������� ��������. 
        /// </summary>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ContactsListBox.SelectedIndex!= -1)
            {
                _currentContact = _contacts[ContactsListBox.SelectedIndex];
                _copiedContact = Model.Contact.CloneContact(_currentContact);
                UpdateInfo(_currentContact);
            }
            else
            {
                ClearInfo();
            }
        }
        
        /// <summary>
        /// ��������� ��������� ���� � ��������� �� � ����� ���������� ��������. 
        /// </summary>
        private void BirthdayDateTimePicker_SelectedDatesChanged(object? sender, EventArgs e)
        {
            WrongBirthdayLabel.Visible = false;
            int value = ContactsListBox.SelectedIndex;
            if (value != -1)
            {
                try
                {
                    DateTime newBirthday = BirthdayDateTimePicker.Value;
                    _copiedContact.Birthday = newBirthday;
                }
                catch
                {
                    WrongBirthdayLabel.Visible = true;
                }
            }
        }

        /// <summary>
        /// ��������� �������� � ��������� ���� � ��������� ��� � ����� ���������� ��������. 
        /// </summary>
        private void PhoneNumberTextBox_TextChanged(object? sender, EventArgs e)
        {
            PhoneNumberTextBox.BackColor = Color.White;
            int value = ContactsListBox.SelectedIndex;
            if (value != -1)
            {
                try
                {
                    string newNumber = PhoneNumberTextBox.Text;
                    _copiedContact.PhoneNumber = newNumber;
                }
                catch
                {
                    PhoneNumberTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// ��������� �������� � ��������� ���� � ��������� ��� � ����� ���������� ��������. 
        /// </summary>
        private void VKcomTextBox_TextChanged(Object? sender, EventArgs e)
        {
            VKcomTextBox.BackColor = Color.White;
            int value = ContactsListBox.SelectedIndex;
            if (value != -1)
            {
                try
                {
                    string newVKcom = VKcomTextBox.Text;
                    _copiedContact.Vkcom = newVKcom;
                }
                catch
                {
                    VKcomTextBox.BackColor = Color.LightPink;
                }
            }
        }

        /// <summary>
        /// ��������� �������� � ��������� ���� � ��������� ��� � ����� ���������� ��������. 
        /// </summary>
        private void FullNameTextBox_TextChanged(object? sender, EventArgs e)
        {
            FullNameTextBox.BackColor = Color.White;
            int value = ContactsListBox.SelectedIndex;
            if(value != -1)
            {
                try
                {
                    string newName = FullNameTextBox.Text;
                    _copiedContact.FullName = newName;
                }
                catch
                {
                    FullNameTextBox.BackColor = Color.LightPink;
                }
            }
        }
        
        /// <summary>
        /// ������� � ��������� ������� � �������� ������� � ������ � ��������. 
        /// </summary>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            _currentContact = new Model.Contact("Full Name", "+", DateTime.Now, "https://vk.com/");
            _contacts.Add(_currentContact);
            ContactsListBox.Items.Add(_currentContact.FullName);
            ProjectSerializer.SaveToFile(_contacts, _directoryPath, _fileName);

        }

        /// <summary>
        /// ��������� �������� �� �������� �� �� ���. 
        /// </summary>
        /// <param name="contacts">����������� ������</param>
        private void SortAlphabetically(List<Model.Contact> contacts)
        {
            contacts.Sort((left, right) => left.FullName.CompareTo(right.FullName));
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_contacts[i].FullName);
            }
        }

        /// <summary>
        /// ������ �������������� ��������. 
        /// </summary>
        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            if(ContactsListBox.SelectedIndex != -1)
            {
                _copiedContact = Model.Contact.CloneContact(_contacts[ContactsListBox.SelectedIndex]);
                ContactsListBox.Enabled= false;
                FullNameTextBox.Enabled = true;
                PhoneNumberTextBox.Enabled = true;
                VKcomTextBox.Enabled = true;
                BirthdayDateTimePicker.Enabled = true;
                CancelButton.Visible = true;
                SaveButton.Visible = true;
            }
            
        }

        /// <summary>
        /// ������� ��������� ���� � �������� ����������� ���� � �������� ��� ��������
        /// </summary>
        private void ClearInfo()
        {
            FullNameTextBox.Clear();
            BirthdayDateTimePicker.Value = DateTime.Now;
            PhoneNumberTextBox.Clear();
            VKcomTextBox.Clear();
        }

        /// <summary>
        /// ��������� ��������� ���� � ���� ��� ��������� ���������� ��������. 
        /// </summary>
        /// <param name="contact">��������� �������. </param>
        private void UpdateInfo(Model.Contact contact)
        {
            FullNameTextBox.Text = contact.FullName;
            BirthdayDateTimePicker.Value = contact.Birthday;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            VKcomTextBox.Text = contact.Vkcom;
        }


        /// <summary>
        /// ��������� ��������� � ��������. 
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Enabled = false;
            PhoneNumberTextBox.Enabled = false;
            BirthdayDateTimePicker.Enabled = false;
            VKcomTextBox.Enabled = false;
            CancelButton.Visible = false;
            SaveButton.Visible = false;
            ContactsListBox.Enabled= true;
            int value = ContactsListBox.SelectedIndex;
            _contacts[value] = _copiedContact;
            SortAlphabetically(_contacts);
            UpdateInfo(_copiedContact);
            ContactsListBox.Items.Clear(); 
            for (int i = 0; i < _contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_contacts[i].FullName);
            }
            for(int i = 0; i < _contacts.Count; i++)
            {
                if(_copiedContact == _contacts[i])
                {
                    ContactsListBox.SelectedIndex = i;
                }
            }
            ProjectSerializer.SaveToFile(_contacts, _directoryPath, _fileName);
        }

        /// <summary>
        /// �������� ��������� � ��������. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearInfo();
            UpdateInfo(_contacts[ContactsListBox.SelectedIndex]);
            FullNameTextBox.Enabled = false;
            PhoneNumberTextBox.Enabled = false;
            BirthdayDateTimePicker.Enabled = false;
            VKcomTextBox.Enabled = false;
            CancelButton.Visible = false;
            SaveButton.Visible = false;
            ContactsListBox.Enabled = true;
        }
    }
}