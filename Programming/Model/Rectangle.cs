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

        public Rectangle()
        {
        }
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

    }
}
