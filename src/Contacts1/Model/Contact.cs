using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts1.Model
{
    /// <summary>
    /// Содержит информацию о контакте
    /// </summary>
    public partial class Contact : ObservableValidator
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
        /// Возвращает и задает имя контакта.
        /// Должно быть короче 100 символов. 
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(100, ErrorMessage = "Name is supposed to be shorter than 100 symbols")]
        public string FullName
        {
            get => _fullName;
            set
            {
                SetProperty(ref _fullName, value, true);
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// Должен быть формата +7(983)000-11-22
        /// </summary>
        [Required]
        [RegularExpression(@"^\+\d{1}\(\d{3}\)\d{3}\-\d{2}-\d{2}$",
            ErrorMessage = "Phone Number can contain only digits and '+-()' symbols. " +
                                    "Example: +7 (999) 111-22-33 ")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                SetProperty(ref _phoneNumber, value, true);
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту.
        /// Должна содержать @. 
        /// </summary>
        [Required]
        [RegularExpression(@"^.*\@.*$",
            ErrorMessage = "Email is supposed to be shorter than 100 symbols and has to contain @ symbol")]
        public string Email
        {
            get => _email;
            set
            {
                SetProperty(ref _email, value, true);
            }
        }

        /// <summary>
        /// Создает объект типа <see cref="Contact"/>
        /// </summary>
        /// <param name="fullName">Полное имя </param>
        /// <param name="email">Электронная почта </param>
        /// <param name="phoneNumber">Номер телефона </param>
        public Contact(string fullName, string phoneNumber, string email)
        {
            FullName = fullName;
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
