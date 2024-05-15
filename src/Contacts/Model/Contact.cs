using CommunityToolkit.Mvvm.ComponentModel;
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
    public class Contact: ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Полное имя.
        /// </summary>
        [ObservableProperty]
        private string _fullName;

        /// <summary>
        /// Электронная почта. 
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        private string _error;

        [ObservableProperty]
        private bool _isError;
        public string Error
        {
            get => _error;
        }

        public string this[string columnName]
        {
            get
            {
                string _error = String.Empty;
                IsError = false;
                switch (columnName)
                {
                    case "FullName":
                        if (FullName != null)
                        {
                            if (FullName.Length > 100 || FullName.Length == 0)
                            {
                                _error = "Name is supposed to be shorter than 100 symbols";
                                IsError= true;
                            }
                        }
                        break;
                    case "PhoneNumber":
                        if (PhoneNumber != null)
                        {
                            if (Regex.IsMatch(PhoneNumber, @"^\+\d{1}\s\(\d{3}\)\s\d{3}\-\d{2}-\d{2}$") == false
                                && Regex.IsMatch(PhoneNumber, @"^\+\d{1}\(\d{3}\)\d{3}\-\d{2}-\d{2}$") == false)
                            {
                                _error = "Phone Number can contain only digits and '+-()' symbols. " +
                                    "Example: +7 (999) 111-22-33 ";
                                IsError= true;
                            }

                        }
                        break;
                    case "Email":
                        if (Email != null)
                        {
                            if (Email.Contains('@') == false || Email.Length > 100)
                            {
                                _error = "Email is supposed to be shorter than 100 symbols " +
                                    "and has to contain @ symbol";
                                IsError= true;
                            }
                        }
                        break;
                }
                return _error;
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
