using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private string _username;
        private string _firstname;
        private string _lastname;

        public string Firstname
        {
            get => _firstname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _firstname = value;
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _lastname = value;
            }
        }
        
        public string Username { get; set; }

        private void AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]*$")==false)
            {
                throw new ArgumentException();
            }

        }
        public Contact()
        {
        }
        public Contact(string firstname, string lastname, string username)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
        }
    }
}
