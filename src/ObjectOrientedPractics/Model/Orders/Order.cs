using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит информацию о заказе.
    /// </summary>
    public class Order: IEquatable<Order>
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает дату создания заказа. 
        /// </summary>
        public string Date { get; }

        /// <summary>
        /// Возвращает идентификатор заказа. 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возваращает и задает список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает общую стоимость товаров. 
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }
                else
                {
                    double total = 0.0;
                    for (int i = 0; i < Items.Count; i++)
                    {
                        total = total + Items[i].Price;
                    }
                    return total;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки. 
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                if (value != null)
                {
                    _address = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает имя покупателя. 
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Возвращает адрес в виде строки. 
        /// </summary>
        public string strAddress
        {
            get
            {
                return Address.Country + " " + Address.City + " " + Address.Street +
                    " " + Address.Building + " " + Address.Apartment;
            }
        }

        /// <summary>
        /// Возвращает и задает статус заказа. 
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает размер скидки. 
        /// </summary>
        public double DiscountAmount { get; set; }  

        /// <summary>
        /// Возвращает общую стоимость заказа с учетом скидки. 
        /// </summary>
        public double Total
        {
            get { return Amount - DiscountAmount; }
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T?)"/>
        public bool Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }
            return other.Id == Id && other.Date == Date;
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Address = new Address();
            Items = new List<Item>();
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            Id = Services.IdGenerator.GetNextID();
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"/>.
        /// </summary>
        /// <param name="customerName">Имя покупателя. </param>
        /// <param name="address">Адрес доставки. </param>
        /// <param name="items">Список товаров. </param>
        public Order(string customerName, Address address, List<Item> items)
        {
            CustomerName = customerName;
            Address = address;
            Items = items;
            OrderStatus = OrderStatus.New;
            Date = DateTime.Now.ToLongDateString();
            Id = Services.IdGenerator.GetNextID();
        }
    }
}
