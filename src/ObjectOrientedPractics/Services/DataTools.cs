using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public class DataTools
    {
        public delegate bool FilterCriteria(Item item, object obj);

        public bool AssertCategory(Item item, object category)
        {
            return item.Category == (Category)category;
        }

        public bool AssertPrice(Item item, object price)
        {
            return item.Price == (double)price;
        }
        public static List<Item> Filter(List<Item> items, FilterCriteria filterCriteria, object obj)
        {
            List<Item> newItems = new List<Item>();
            foreach (Item item in items)
            {
                if(filterCriteria(item, obj))
                {
                    newItems.Add(item);
                }
            }
            return newItems;
        }
    }
}
