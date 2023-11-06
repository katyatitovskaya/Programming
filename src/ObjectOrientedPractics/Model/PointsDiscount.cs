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
                if (value >= 0)
                {
                    _points = value;
                }
            }
        }

        public double Total { get; set; } 

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public double Calculate(List<Item> items)
        {
            if(items==null || items.Count == 0) return 0;
            
            int total30 = (int)Total / 100 * 30;
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
            Total = Total - Calculate(items);
            Points = Points - (int)Calculate(items);
            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            Points = Points + (int)(Total / 10);
            if (Total % 10 != 0)
                Points = Points + 1;
        }

    }
}
