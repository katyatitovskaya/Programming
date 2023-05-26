using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contacts
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
                AssertStringContainsOnlyLetters(value, nameof(FullName));
            }
        }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Vkcom { get; set; }
        /// <summary>
        /// Проверяет, все ли символы в строке являются буквами англ алфавита. 
        /// </summary>
        /// <param name="value">Проверяемая строка. </param>
        /// <param name="name">Имя свойства, в котором присваивается значение. </param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value, string name)
        {
            StackTrace stacktrace = new StackTrace();
            if (Regex.IsMatch(value, "^[a-zA-Z]*$") == false)
            {
                throw new ArgumentException($"value in {name} " +
                    $"is suposed to contain only letters");
            }

        }
        public Contacts(string fullName, string phoneNumber, DateTime birthday, string vkcom)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;

        }
    }
}
