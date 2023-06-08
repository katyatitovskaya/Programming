using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contact
    {
        private string _fullName;
        private string _phoneNumber;
        private DateTime _birthday;
        private string _vkcom;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FullName));
                Validator.AssertStingLengthIsInRange(value, 150, nameof(FullName));
                _fullName = value;
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                Validator.AssertStringIsAPhoneNumber(value, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                Validator.AssertDateIsInRange(value, nameof(Birthday));
                _birthday = value;
            }
        }
        public string Vkcom
        {
            get => _vkcom;
            set
            {
                Validator.AssertStringIsURL(value, nameof(Vkcom));
                _vkcom = value;
            }
        }
        public static Contact CloneContact(Contact contact)
        {
            return new Contact(contact.FullName, contact.PhoneNumber, contact.Birthday, contact.Vkcom);
        }
        
        public Contact()
        {
        }
        public Contact(string fullName, string phoneNumber, DateTime birthday, string vkcom)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Vkcom = vkcom;
        }
    }
}
