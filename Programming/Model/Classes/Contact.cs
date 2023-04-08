using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    public class Contact
    {
        private string _firstname;
        private string _lastname;

        public string Firstname
        {
            get => _firstname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Firstname));
                _firstname = value;
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Lastname));
                _lastname = value;
            }
        }

        public string Username { get; set; }

        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            StackTrace stacktrace = new StackTrace();
            if (Regex.IsMatch(value, "^[a-zA-Z]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only letters");
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
