using Contacts.Model;
using Contacts.Model.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace Contacts.ViewModel
{
    /// <summary>
    /// Хранит информацию о данных, связывающих Model и View между собой. 
    /// </summary>
    public class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Команда сохранения объекта. 
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Команда выгрузки объекта.
        /// </summary>
        private ICommand _loadCommand;

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RelayCommand _removeCommand;
        
        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Команда утверждения изменений.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Флаг, показывающий, редактируется ли контакт.
        /// </summary>
        private bool _isEdited;

        /// <summary>
        /// Флаг, показывающий, добавляется ли контакт.
        /// </summary>
        private bool _isAdded;

        /// <summary>
        /// Флаг, показывающий, доступны поля только для чтения или нет.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Индекс выбранного контакта. 
        /// </summary>
        private int _indexOfSelectedContact;

        /// <summary>
        /// Создает экземпляр типа <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            SelectedContact= new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
            Contacts = ContactSerializer.LoadFromFile();
            IsReadOnly= true;
        }

        /// <summary>
        /// Возвращает и задает список контактов. 
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный контакт. 
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if(_selectedContact !=value)
                {
                    _selectedContact = value;
                    OnPropertyChanged(nameof(SelectedContact));
                    if(Contacts.Contains(value))
                    {
                        IsEdited = false;
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задает индект выбранного контакта. 
        /// </summary>
        public int IndexOfSelectedContact
        {
            get => _indexOfSelectedContact;
            set
            {
                _indexOfSelectedContact = value;
                OnPropertyChanged(nameof(IndexOfSelectedContact));
            }
        }
        
        /// <summary>
        /// Возвращает команду сохранения объекта. 
        /// </summary>
        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        /// <summary>
        /// Возвращает команду выгрузки объекта. 
        /// </summary>
        public ICommand LoadCommand
        {
            get { return _loadCommand; }
        }

        /// <summary>
        /// Возвращает и задает флаг, редактируется ли контакт. 
        /// </summary>
        public bool IsEdited
        {
            get => _isEdited;
            set
            {
                _isEdited = value;
                OnPropertyChanged(nameof(IsEdited));
            }
        }

        /// <summary>
        /// Возвращает и задает флаг, добавляется ли контакт. 
        /// </summary>
        public bool IsAdded
        {
            get => _isAdded;
            set
            {
                if(_isAdded!=value)
                {
                    _isAdded = value;
                    OnPropertyChanged(nameof(IsAdded));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает флаг, доступны поля только на чтение или нет. 
        /// </summary>
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value; 
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      IsAdded = true;
                      IsEdited = true;
                      IsReadOnly = false;
                      SelectedContact = new Contact();
                  },
                  (obj) => (IsEdited==false)
                  ));
            }
        }

        /// <summary>
        /// Возвращает команду удаления контакта. 
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                  (_removeCommand = new RelayCommand(obj =>
                  {
                      int index = Contacts.IndexOf(SelectedContact);
                      Contacts.Remove(SelectedContact);
                      if (Contacts.Count > 0 && index!=0)
                      {
                          SelectedContact = Contacts[index - 1];
                      }
                      else if(Contacts.Count > 0)
                      {
                          SelectedContact = Contacts.Last();
                      }
                      ContactSerializer.SaveToFile(Contacts);

                  },
                  (obj) => (Contacts.Count > 0 && SelectedContact!=null
                  && IsEdited==false && Contacts.IndexOf(SelectedContact)!=-1)));
            }
        }

        /// <summary>
        /// Возвращает команду редактирования контакта. 
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                  (_editCommand = new RelayCommand(obj =>
                  {
                      IsReadOnly = false;
                      IsEdited = true;
                      IndexOfSelectedContact = Contacts.IndexOf(SelectedContact);
                      SelectedContact = new Contact(SelectedContact.FullName,
                              SelectedContact.PhoneNumber, SelectedContact.Email);
                  },
                  (obj) => (SelectedContact!=null && Contacts.Count>0
                  && Contacts.IndexOf(SelectedContact)!=-1)));
            }
        }

        /// <summary>
        /// Возвращает команду применения изменений. 
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                  (_applyCommand = new RelayCommand(obj =>
                  {
                      if (IsAdded)
                      {
                          Contacts.Add(SelectedContact);
                          IsAdded= false;
                      }
                      else
                      {
                          Contacts[IndexOfSelectedContact] = SelectedContact;
                          SelectedContact = Contacts[IndexOfSelectedContact];
                      }
                      IsEdited = false;
                      IsReadOnly = true;
                      ContactSerializer.SaveToFile(Contacts);
                  },
                  (obj) => (SelectedContact!=null)));
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
    }
}
