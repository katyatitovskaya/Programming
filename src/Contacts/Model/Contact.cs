using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Model
{
    /// <summary>
    /// Содержит информацию о контакте
    /// </summary>
    public class Contact:INotifyPropertyChanged
    {
        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Электронная почта. 
        /// </summary>
        private string _email;
        
        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Возвращает и задает полное имя.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту. 
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает и задает Номер телефона. 
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Событие, показывающее изменения 
        /// в свойствах класса <see cref="MainVM"/>
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод зажигающий событие при изменении свойств. 
        /// </summary>
        /// <param name="prop">Имя свойства</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

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
