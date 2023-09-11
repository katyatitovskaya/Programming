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
        private string _address; 


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
        /// Должен быть короче 500 символов. 
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                Services.ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает индивидуальный идентификатор товара. 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает и задает индивидуальный идентификатор товара. 
        /// </summary>
        public static int NewId { get; set; }

        /// <summary>
        /// Создает объект класса <see cref="Customer"/>.  
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Создает объект класса <see cref="Customer"/>.  
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. Должно быть короче 200 символов. </param>
        /// <param name="address">Адрес покупателя. Должен быть короче 500 символов. </param>
        public Customer(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
            Id = NewId;
            NewId++;
        }
    }
}
