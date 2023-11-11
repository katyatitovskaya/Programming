using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о корзине. 
    /// </summary>
    public class Cart: ICloneable
    {
        /// <summary>
        /// Возвращает и задает список товаров. 
        /// </summary>
        public List<Item> Items { get; set; } 

        /// <summary>
        /// Возваращает общую стоимость товаров в корзине. 
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
                    for(int i = 0; i< Items.Count; i++)
                    {
                        total = total + Items[i].Price;
                    }
                    return total;
                }
            }
        }

        public object Clone()
        {
            return new Cart(Items);
        }

        /// <summary>
        /// Создает объект типа <see cref="Cart"/>.
        /// </summary>
        public Cart(List<Item> items)
        {
            Items = items;
        }
    }
}
