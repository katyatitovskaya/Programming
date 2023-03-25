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
        private string _color;

        public double Length
        {
            get { return _length; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Длина должна быть больше нуля");
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ширина должна быть больше нуля");
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
