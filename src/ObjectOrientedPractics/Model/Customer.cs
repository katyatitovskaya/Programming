using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях. 
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Полное имя покупателя. 
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя. 
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает полное имя покупателя. 
        /// Должно быть короче 200 символов. 
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullname = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        
        /// <summary>
        /// Возвращает индивидуальный идентификатор товара. 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает список заказов. 
        /// </summary>
        public List<Order> Orders { get; set; }


        /// <summary>
        /// Возвращает и задает корзину. 
        /// </summary>
        public Cart Cart { get; set; }


        /// <summary>
        /// Создает объект класса <see cref="Customer"/>.  
        /// </summary>
        public Customer()
        {
            Id = Services.IdGenerator.GetNextID();
        }

        /// <summary>
        /// Создает объект класса <see cref="Customer"/>.  
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Должно быть короче 200 символов. </param>
        /// <param name="address">Адрес покупателя. </param>
        public Customer(string fullname)
        {
            FullName = fullname;
            Address = new Address(100000, "Country", "City", 
                "Street", "Building", "Apartment");
            Id = Services.IdGenerator.GetNextID();
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
