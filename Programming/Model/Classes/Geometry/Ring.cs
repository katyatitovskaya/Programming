using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит информацию о кольцах. 
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус. 
        /// </summary>
        private double _innerradius;
        /// <summary>
        /// Внешний радиус. 
        /// </summary>
        private double _outerradius;

        /// <summary>
        /// Возвращает и задает центр кольца. 
        /// </summary>
        public Point2D Centre { get; set; }
        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен входить в диапазон от 0 до значения внешнего радиуса. 
        /// </summary>
        public double InnerRadius
        {
            get => _innerradius;
            private set
            {
                Validator.AssertValueInRange(value, 0, OuterRadius, nameof(InnerRadius));
                _innerradius = value;
            }
        }
        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть больше внутреннего радиуса. 
        /// </summary>
        public double OuterRadius
        {
            get => _outerradius;
            private set
            {
                Validator.AssertValueInRange(value, InnerRadius, double.MaxValue, nameof(OuterRadius));
                _outerradius = value;
            }
        }
        /// <summary>
        /// Считает площадь кольца. 
        /// </summary>
        /// <param name="ring">Кольцо. </param>
        /// <returns>Возвращает площадь кольца. </returns>
        private static double Area(Ring ring)
        {
            double area = Math.PI * Math.Pow(ring.OuterRadius, 2) - Math.PI * Math.Pow(ring.InnerRadius, 2);
            return area;
        }
        public static int AllRingsCount { get; set; }
        public int Id { get; }
        /// <summary>
        /// Создает объект класса <see cref="Ring="/>.
        /// </summary>
        /// <param name="outerRadius">Внешний радиус. Должен быть положительным. </param>
        /// <param name="innerRadius">Внутренний радиус. Должен быть положительеым. </param>
        /// <param name="x">Координата центра кольца X. Должна быть положительной. </param>
        /// <param name="y">Координата центра кольца Y. Должна быть положительной. </param>
        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = new Point2D(x, y);
            Id = AllRingsCount;
            AllRingsCount++;
        }
        /// <summary>
        /// Создает объект класса <see cref="Ring"/>. 
        /// </summary>
        public Ring()
        {
        }
    }
}
