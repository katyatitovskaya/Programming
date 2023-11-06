using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        public int Points
        {
            get => _points;
            private set
            {
                if (value >= 0)
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
            foreach (Item item in items)
            {
                total += item.Price;
            }
            double total30 = total * 0.3;
            if (Points > total30)
            {
                return Math.Ceiling(total30);
            }
            return Points;
        }

        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= Convert.ToInt32(discount);
            return discount;
        }

        public void Update(List<Item> items)
        {
            double total = 0;
            foreach (Item item in items)
            {
                total += item.Price;
            }
            Points = Points + (int)(total / 10);
            if (total % 10 != 0)
                Points = Points + 1;
        }

    }
}
