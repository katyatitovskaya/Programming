using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Model
{
    public class Contact
    {
        private string _fullName;
        private string _email;
        private string _phoneNumber;

        public string FullName
        {
            get => _fullName;
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Zа-яА-Я ]*$") == false)
                {
                    throw new ArgumentException($"value is suposed " +
                        $"to contain only letters");
                }
                if(value.Length> 0 )
                {
                    _fullName = value;
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (value.Contains("@mail.com") == false || value.Contains("@yandex.ru") == false)
                {
                    throw new ArgumentException("value is supposed to contain full mail address" +
                        "including @mail.com/@yandex.ru");
                }
                if(value.Length> 0 )
                {
                    _email = value;
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.StartsWith("+") == false || Regex.IsMatch(value.Substring(1, value.Length - 1), "^[0-9]*$") == false)
                {
                    throw new ArgumentException($"value is suposed to contain only digits or +");
                }
                if (value.Length> 0 )
                {
                    _phoneNumber = value;
                }
            }
        }

        public Contact(string fullName, string email, string phoneNumber)
        {
            FullName= fullName;
            Email= email;
            PhoneNumber= phoneNumber;
        }

        public Contact()
        {
        }
    }
}
