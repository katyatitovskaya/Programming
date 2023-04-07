using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        public double Length
        {
            get => _length;
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }
        public string Color { get;  set; }
        public Point2D Centre { get; set; }

        public static int AllRectanglesCount { get; set; }

        public int Id { get; }

        public Rectangle()
        {
        }
        public Rectangle(double length, double width, string color, double x, double y)
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
