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
        //public delegate bool FilterCriteria(Item item, object obj);

        public delegate List<Item> SortingDelegate(List<Item> items); 

        public bool AssertCategory(Item item, object category)
        {
            return item.Category == (Category)category;
        }

        public bool AssertPrice(Item item, object price)
        {
            return item.Price == (double)price;
        }
        public static List<Item> Filter(List<Item> items, Func<Item, object, bool> filterCriteria, object obj)
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

        public static List<Item> SortCostAscending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Price < items[j-1].Price)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        public static List<Item> SortCostDescending(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                for (int j = 1; j < items.Count; j++)
                {
                    if (items[j].Price > items[j - 1].Price)
                    {
                        Item temp = items[j];
                        items[j] = items[j - 1];
                        items[j - 1] = temp;
                    }
                }
            }
            return items;
        }

        public static List<Item> SortName(List<Item> items)
        {
            items.Sort((left, right) => left.Name.CompareTo(right.Name));
            return items;
        }

        public static List<Item> Sort(List<Item> items, SortingDelegate sortingDelegate)
        {
            return sortingDelegate(items);
        }
    }
}
