using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        private int _percent=1;

        public double Total { get; private set; }
        public List<Item> Items { get; set; }
        public Category Category { get; set; }
        public int Percent
        {
            get => _percent;
            private set
            {
                if (value >= 1)
                {
                    _percent = value;
                }
            }
        }

        public string Info
        {
            get 
            {
                return $"Процентная {Category} - {Percent}% ";
            }
        }

        public double Calculate(List<Item> items)
        {
            Total= 0;
            if(items.Count == 0 || items==null) return Percent;
            int counter = 0;
            for(int i =0; i<items.Count; i++)
            {    
                if (items[i].Category== Category)
                {
                    counter++;
                    Total += items[i].Price;
                }
            }
            if (counter == 0) return Percent;
            else
            {
                return Percent;
            }
        }


        public double Apply(List<Item> items)
        {
            Total = 0;
            if (items.Count == 0 || items == null) return Percent;
            int counter = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    counter++;
                    items[i].Price -= (items[i].Price / 100 * Percent);
                    Total += items[i].Price;
                }
            }
            if (counter == 0) return Percent;
            return Percent;
            
        }

        public void Update(List<Item> items)
        {
            if (Total > 1000 && Percent < 10)
            {
                Percent += 1;
            }
        }
    }

}
