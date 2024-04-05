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
        /// Коллекция контактов. 
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        private Contact _selectedContact;

        private int _selectedContactIndex;

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
                }
            }
        }

        public int SelectedContactIndex
        {
            get => _selectedContactIndex;
            set
            {
                if(_selectedContactIndex != value)
                {
                    _selectedContactIndex = value;
                    OnPropertyChanged(nameof(SelectedContactIndex));
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

        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      IsAdded= true;
                      IsEdited= true;
                      VisibilityMode = Visibility.Visible;
                      SelectedContact = new Contact();
                  }));
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                  (_removeCommand = new RelayCommand(obj =>
                  {
                      if(SelectedContact!= null)
                      {
                          Contacts.Remove(SelectedContact);
                      }
                      else
                      {
                          SelectedContact = Contacts.Last();
                      }
                      ContactSerializer.SaveToFile(Contacts);

                  }));
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                  (_editCommand = new RelayCommand(obj =>
                  {
                      IsEdited= true;
                      VisibilityMode= Visibility.Visible;
                  }));
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
                          IsEdited = false;
                          
                      }
                      else if (IsEdited == true && IsAdded == false)
                      {
                          IsEdited = false;
                          SelectedContact = new Contact(SelectedContact.FullName,
                              SelectedContact.PhoneNumber, SelectedContact.Email);
                      }
                      VisibilityMode = Visibility.Hidden;
                      ContactSerializer.SaveToFile(Contacts);
                  }));
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
