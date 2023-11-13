using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит информацию о скидках в формате баллов. 
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Баллы.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает и задает баллы. Должно быть неотрицательным. 
        /// </summary>
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

        /// <summary>
        /// Возвращает информацию о скидке. 
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public int CompareTo(PointsDiscount other)
        {
            if(other == null)
            {
                return 1;
            }
            return this.Points.CompareTo(other.Points);
        }

        /// <summary>
        /// Считает размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Размер скидки. </returns>
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

        /// <summary>
        /// Применяет скидку. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
        /// <returns>Размер скидки. </returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= Convert.ToInt32(discount);
            return discount;
        }

        /// <summary>
        /// Обновляет размер скидки. 
        /// </summary>
        /// <param name="items">Список товаров. </param>
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
