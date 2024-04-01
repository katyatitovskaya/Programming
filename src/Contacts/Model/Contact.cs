using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Model
{
    /// <summary>
    /// Содержит информацию о контакте
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает полное имя
        /// </summary>
        public string FullName { get; set; }

        
        /// <summary>
        /// Возвращает и задает электронную почту
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задает номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="Contact"/>
        /// </summary>
        /// <param name="fullName">Полное имя </param>
        /// <param name="email">Электронная почта </param>
        /// <param name="phoneNumber">Номер телефона </param>
        public Contact(string fullName, string phoneNumber, string email)
        {
            FullName= fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создает объект типа <see cref="Contact"/>
        /// </summary>
        public Contact()
        {
        }
    }
}
