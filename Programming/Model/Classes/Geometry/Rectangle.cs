using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольниках. 
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;
        /// <summary>
        /// Ширина прямоугольника. 
        /// </summary>
        private double _width;

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть положительной. 
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }
        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительной. 
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _width = value;
            }
        }
        /// <summary>
        /// Возвращает и задает цвет прямоугольника. 
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Возвращает и задает центр прямоугольника. 
        /// </summary>
        public Point2D Centre { get; set; }
        /// <summary>
        /// Возвращает и задает индивидуальный идентивикатор. 
        /// </summary>
        public static int AllRectanglesCount { get; set; }
        /// <summary>
        /// Вохвращает индивидуальный идентивикатор. 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Создает объект класса <see cref="Rectangle"/>. 
        /// </summary>
        public Rectangle()
        {
        }
        /// <summary>
        /// Создает объект класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина. Должна быть положительной. </param>
        /// <param name="width">Ширина. Должна быть положительной. </param>
        /// <param name="color">Цвет. </param>
        /// <param name="x">Координата центра прямоугольника Х. Должна быть положительной. </param>
        /// <param name="y">Координата центра прямоугольника Y. Должна быть положительной. </param>
        public Rectangle(double length, double width, string color, int x, int y)
        {
            Length = length;
            Width = width;
            Color = color;
            Centre = new Point2D(x, y);
            Id = AllRectanglesCount;
            AllRectanglesCount++;
        }

    }
}
