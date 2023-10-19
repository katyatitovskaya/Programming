﻿using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        private List<Item> _items;
        private List<Customer> _customers;

        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }
        public List<Customer> Customers
        {
            get=>_customers;
            set
            {
                _customers = value;
            }
        }
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }

    }
}
