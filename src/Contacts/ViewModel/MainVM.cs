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

        private Contact _selectedContact;

        /// <summary>
        /// Команда сохранения объекта. 
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Команда выгрузки объекта.
        /// </summary>
        private ICommand _loadCommand;

        private RelayCommand _addCommand;

        private RelayCommand _removeCommand;

        private RelayCommand _editCommand;

        private RelayCommand _applyCommand;

        private bool _isEdited;

        private bool _isAdded;
        private bool _isReadOnly;

        private Visibility _visibilityMode = Visibility.Hidden;

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
        }

        public ObservableCollection<Contact> Contacts { get; set; }

        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if(_selectedContact !=value)
                {
                    _selectedContact = value;
                    OnPropertyChanged(nameof(SelectedContact));
                    IsEdited = false;
                }
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

        public bool IsEdited
        {
            get => _isEdited;
            set
            {
                if(_isEdited!=value)
                {
                    _isEdited = value;
                    OnPropertyChanged(nameof(IsEdited));
                }
            }
        }

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

        public Visibility VisibilityMode
        {
            get => _visibilityMode;
            set
            {
                _visibilityMode = value; 
                OnPropertyChanged(nameof(VisibilityMode));
            }
        }

        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value; 
                OnPropertyChanged(nameof(IsReadOnly));
            }
        }

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
                      VisibilityMode = Visibility.Visible;
                      SelectedContact = new Contact();
                  },
                  (obj) => (IsEdited==false)
                  ));
            }
        }

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

        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                  (_editCommand = new RelayCommand(obj =>
                  {
                      IsReadOnly = false;
                      IsEdited = true;
                      VisibilityMode = Visibility.Visible;
                  },
                  (obj) => (SelectedContact!=null && Contacts.Count>0
                  && Contacts.IndexOf(SelectedContact)!=-1)));
            }
        }

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
                          int index = Contacts.IndexOf(SelectedContact);
                          SelectedContact = new Contact(SelectedContact.FullName,
                              SelectedContact.PhoneNumber, SelectedContact.Email);
                          SelectedContact = Contacts[index];
                      }
                      IsEdited = false;
                      IsReadOnly = true;
                      VisibilityMode = Visibility.Hidden;
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
