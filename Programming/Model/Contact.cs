﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        private int _number;

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Number
        {
            get => _number;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Номер телефона не может быть отрицательным");
                _number = value;
            }
        }
        public Contact()
        {
        }
        public Contact(string firstname, string lastname, int number)
        {
            Firstname = firstname;
            Lastname = lastname;
            Number = number;
        }
    }
}