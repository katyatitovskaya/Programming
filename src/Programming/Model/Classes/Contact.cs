using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    /// <summary>
    /// Хранит информацию о человеке и его контактных данных. 
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _firstname;

        /// <summary>
        /// Фамилия. 
        /// </summary>
        private string _lastname;
        
        /// <summary>
        /// Возвращает и задает имя человека. Должно состоять только из букв.
        /// </summary>
        public string Firstname
        {
            get => _firstname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Firstname));
                _firstname = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает фамилию человека. Должна состоять только из букв.
        /// </summary>
        public string Lastname
        {
            get => _lastname;
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Lastname));
                _lastname = value;
            }
        }
        
        /// <summary>
        /// Возвразает и задает юзерныейм. 
        /// </summary>
        public string Username { get; set; }
        
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
        
        /// <summary>
        /// Создает объект класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }
        
        /// <summary>
        /// Создает объект класса <see cref="Contact"/>. 
        /// </summary>
        /// <param name="firstname">Имя. Должно состоять только из букв. </param>
        /// <param name="lastname">Фамилия. Должна состоять только из букв. </param>
        /// <param name="username">Юзернейм. </param>
        public Contact(string firstname, string lastname, string username)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
        }
    }
}
