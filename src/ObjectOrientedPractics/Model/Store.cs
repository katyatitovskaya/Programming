using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о магазине. 
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Товары. 
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатели. 
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров. 
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей. 
        /// </summary>
        public List<Customer> Customers
        {
            get=>_customers;
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Созадает объект класса <see cref="Store"/>. 
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
