using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        private int _percent;

        public double Total { get; set; }
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
            if(items.Count == 0 || items==null) return 0;
            int counter = 0;
            for(int i =0; i<items.Count; i++)
            {    
                if (items[i].Category== Category)
                {
                    counter++;
                }
            }
            if (counter == 0) return 0;
            else
            {
                return Percent;
            }
        }


        public double Apply(List<Item> items)
        {
            if (items.Count == 0 || items == null) return 0;
            int counter = 0;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == Category)
                {
                    counter++;
                    items[i].Price =- items[i].Price / 100 * Percent;
                }
            }
            if (counter == 0) return 0;
            return Percent;
            
        }

        public void Update(List<Item> items)
        {
            if (Total > 1000 && Percent < 10)
            {
                Percent = +1;
            }
        }
    }

}
