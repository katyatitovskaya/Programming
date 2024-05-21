using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class Contact: ObservableValidator
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

        [ObservableProperty]
        private bool _isEdited;

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

        [Required]
        [RegularExpression(@"^\+\d{1}\(\d{3}\)\d{3}\-\d{2}-\d{2}$",
            ErrorMessage = "Phone Number can contain only digits and '+-()' symbols. " +
                                    "Example: +7 (999) 111-22-33 ")]
        public string PhoneNumber
        {
            get=> _phoneNumber;
            set
            {
                SetProperty(ref _phoneNumber, value, true);
            }
        }

        [Required]
        [RegularExpression(@"^.*\@.*$", 
            ErrorMessage = "Email is supposed to be shorter than 100 symbols and has to contain @ symbol")]
        public string Email
        {
            get => _email;
            set
            {
                SetProperty (ref _email, value, true);
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
