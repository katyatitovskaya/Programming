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
    public class MainVM: INotifyPropertyChanged
    {
        private Model.Contact _contact;
        private ICommand _saveCommand;
        private ICommand _loadCommand;

        public MainVM()
        {
            _contact = new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
        }
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

        public ICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        public ICommand LoadCommand
        {
            get { return _loadCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
