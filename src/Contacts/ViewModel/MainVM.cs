using Contacts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Хранит информацию о данных, связывающих Model и View между собой. 
    /// </summary>
    public class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт. 
        /// </summary>
        private Model.Contact _contact;

        /// <summary>
        /// Команда сохранения объекта. 
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Команда выгрузки объекта.
        /// </summary>
        private ICommand _loadCommand;

        /// <summary>
        /// Создает экземпляр типа <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
        }

        /// <summary>
        /// Возвращает и задает полное имя контакта. 
        /// </summary>
        public string FullName
        {
            get => _contact.FullName;
            set
            {
                if(_contact.FullName != value)
                {
                    _contact.FullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона. 
        /// </summary>
        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {
                if(_contact.PhoneNumber != value)
                {
                    _contact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта. 
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                if(_contact.Email!=value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
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
