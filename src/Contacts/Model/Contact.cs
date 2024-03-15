using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts.Model
{
    public class Contact
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Contact(string fullName, string email, string phoneNumber)
        {
            FullName= fullName;
            PhoneNumber= phoneNumber;
            Email = email;
        }

        public Contact()
        {
        }
    }
}
