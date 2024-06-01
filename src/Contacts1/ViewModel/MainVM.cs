using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts1.Model;
using Contacts1.Model.Services;

namespace Contacts1.ViewModel
{
    /// <summary>
    /// Хранит информацию о данных, связывающих Model и View между собой. 
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                SetProperty(ref _selectedContact, value);
                if (Contacts.Contains(value) && IsEdited == true)
                {
                    IsEdited = false;
                    IsReadOnly = true;
                }
                IndexOfSelectedContact = Contacts.IndexOf(value);
            }
        }

        /// <summary>
        /// Флаг, показывающий, редактируется ли контакт.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AddCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        private bool _isEdited;

        /// <summary>
        /// Флаг, показывающий, добавляется ли контакт.
        /// </summary>
        [ObservableProperty]
        private bool _isAdded;

        /// <summary>
        /// Флаг, показывающий, доступны поля только для чтения или нет.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly;

        /// <summary>
        /// Индекс выбранного контакта. 
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveCommand))]
        private int _indexOfSelectedContact;

        /// <summary>
        /// Создает экземпляр типа <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            SelectedContact = new Contact();
            Contacts = ContactSerializer.LoadFromFile();
            IsReadOnly = true;
            IsEdited = false;
        }


        /// <summary>
        /// Возвращает и задает коллекцию контактов. 
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Команда загрузки контактов из файла. 
        /// </summary>
        [RelayCommand]
        public void Load()
        {
            var contact = ContactSerializer.LoadFromFile();
        }

        /// <summary>
        /// Команда сохранения контактов в файл. 
        /// </summary>
        [RelayCommand]
        public void Save()
        {
            var fullName = SelectedContact.FullName;
            var phoneNumber = SelectedContact.PhoneNumber;
            var email = SelectedContact.Email;
            var contacts = new ObservableCollection<Contact>()
                        { new Contact(fullName, phoneNumber, email) };
            ContactSerializer.SaveToFile(contacts);
        }

        /// <summary>
        /// Команда добавления контакта. 
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanAdd))]
        public void Add()
        {
            IsAdded = true;
            IsEdited = true;
            IsReadOnly = false;
            SelectedContact = new Contact();
            IndexOfSelectedContact = Contacts.Count();
        }

        /// <summary>
        /// Возвращает может ли быть добавлен контакт.
        /// </summary>
        public bool CanAdd()
        {
            return IsEdited == false;
        }

        /// <summary>
        /// Команда удаления контакта. 
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanRemoveExecute))]
        public void Remove()
        {
            int index = Contacts.IndexOf(SelectedContact);
            Contacts.Remove(SelectedContact);
            if (Contacts.Count > 0 && index != 0)
            {
                SelectedContact = Contacts[index - 1];
            }
            else if (Contacts.Count > 0)
            {
                SelectedContact = Contacts.Last();
            }
            IndexOfSelectedContact = Contacts.IndexOf(SelectedContact);
            ContactSerializer.SaveToFile(Contacts);
        }

        /// <summary>
        /// Возвращает может ли быть удален контакт. 
        /// </summary>
        public bool CanRemoveExecute()
        {
            return (Contacts.Count > 0 && SelectedContact != null
                  && IsEdited == false && IndexOfSelectedContact != -1);
        }

        /// <summary>
        /// Команда редактирования контакта. 
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanEdit))]
        public void Edit()
        {
            IsReadOnly = false;
            IsEdited = true;
            int index = Contacts.IndexOf(SelectedContact);
            SelectedContact = new Contact(SelectedContact.FullName,
                    SelectedContact.PhoneNumber, SelectedContact.Email);
            IndexOfSelectedContact = index;
        }

        /// <summary>
        /// Возвращает может ли быть изменен контакт. 
        /// </summary>
        public bool CanEdit()
        {
            return SelectedContact != null && Contacts.Count > 0
                  && IndexOfSelectedContact != -1 && IsEdited == false;
        }

        /// <summary>
        /// Команда применения изменений. 
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanApply))]
        public void Apply()
        {
            if (IsAdded)
            {
                Contacts.Add(SelectedContact);
                IsAdded = false;
                SelectedContact = Contacts[IndexOfSelectedContact];
            }
            else
            {
                Contacts[IndexOfSelectedContact] = SelectedContact;
            }
            IsEdited = false;
            IsReadOnly = true;
            ContactSerializer.SaveToFile(Contacts);
        }

        /// <summary>
        /// Возвращает могут ли быть применены изменения в контакте. 
        /// </summary>
        public bool CanApply()
        {
            return SelectedContact != null && SelectedContact.HasErrors == false;
        }
    }
}
