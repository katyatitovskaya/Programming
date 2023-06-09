using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContactsApp.Model
{
    [Serializable]
    
    /// <summary>
    /// Хранит информацию о человеке и его контактных данных. 
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта. 
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// День рождения.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Ссылка на страничку в Вконтакте.
        /// </summary>
        private string _vkcom;

        /// <summary>
        /// Возвращает и задает полное имя контакта. 
        /// Должно состоять только из букв и быть не длиннее 150 символов.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает номер телефона. 
        /// Должен состоять только из цифр и начинаться с +.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                Validator.AssertStringIsAPhoneNumber(value, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает и задает день рождения. Должно быть не позже сегодняшней даты. 
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                Validator.AssertDateIsInRange(value, nameof(Birthday));
                _birthday = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ссылку на вк. Должно содержать https://vk.com/.
        /// </summary>
        public string Vkcom
        {
            get => _vkcom;
            set
            {
                Validator.AssertStringIsURL(value, nameof(Vkcom));
                _vkcom = value;
            }
        }

        /// <summary>
        /// Создает копию выбранного объекта класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="contact">Выбранный объект класса <see cref="Contact"/>.</param>
        /// <returns>Возвращает копию объекта класса <see cref="Contact"/>.</returns>
        public static Contact CloneContact(Contact contact)
        {
            return new Contact(contact.FullName, contact.PhoneNumber, contact.Birthday, contact.Vkcom);
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
        /// <param name="fullName">Полное имя. </param>
        /// <param name="phoneNumber">Номер телефона. </param>
        /// <param name="birthday">День рождения. </param>
        /// <param name="vkcom">Ссылка на вк. </param>
        public Contact(string fullName, string phoneNumber, DateTime birthday, string vkcom)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            Vkcom = vkcom;
        }
    }
}
