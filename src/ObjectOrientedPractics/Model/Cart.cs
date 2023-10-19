using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items;
       

        public List<Item> Items { get; set; } 

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

        public Cart()
        {
        }
    }
}
