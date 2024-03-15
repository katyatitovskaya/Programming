using Contacts.Model.Services;
using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Contacts.ViewModel
{
    public class SaveCommand: ICommand
    {
        public MainVM DataContext { get; set; }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        { 
            return true; 
        }
        public void Execute(object parameter)
        {
            var fullName = DataContext.FullName;
            var phoneNumber = DataContext.PhoneNumber;
            var email = DataContext.Email;
            var contacts = new Contact(fullName, phoneNumber, email);
            Model.Services.ContactSerializer.SaveToFile(contacts);
        }

        public SaveCommand(MainVM dataContext)
        {
            DataContext = dataContext;
        }
    }
}
