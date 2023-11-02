using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder: Order
    {
        /// <summary>
        /// Возвращает и задает желаемое время доставки. 
        /// </summary>
        public string DeliveryTime { get; set;}

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="customerName">Имя покупателя. </param>
        /// <param name="address">Адрес. </param>
        /// <param name="items">Список товаров. </param>
        /// <param name="deliveryTime">Время доставки. </param>
        public PriorityOrder(string customerName, Address address, List<Item> items, string deliveryTime):base(customerName, address, items)
        {
            DeliveryTime= deliveryTime;
        }
    }
}
