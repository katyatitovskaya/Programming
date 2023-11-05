using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _points;
        public int Points
        {
            get => _points;
            private set
            {
                if(value > 0)
                {
                    _points = value;
                }
            }
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public double Calculate(List<Item> items)
        {
            double total = 0;
            if (items == null || items.Count == 0)
            {
                total = 0.0;
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    total = total + items[i].Price;
                }
            }
            int total30 = (int)total / 100 * 30;
            if(total30 > Points)
            {
                return Points;
            }
            else
            {
                return total30;
            }
        }

        public double Apply(List<Item> items)
        {
            double total = 0;
            if (items == null || items.Count == 0)
            {
                total = 0.0;
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    total = total + items[i].Price;
                }
            }
            total = total - Calculate(items);
            Points = Points - (int)Calculate(items);
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            double total = 0;
            if (items == null || items.Count == 0)
            {
                total = 0.0;
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    total = total + items[i].Price;
                }
            }
            Points = Points + (int)(total / 10);
            if (total % 10 != 0)
                Points = Points + 1;
        }

    }
}
