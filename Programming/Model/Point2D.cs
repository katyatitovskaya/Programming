using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        public double _x;
        public double _y;

        public double X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }
        public double Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }
        public Point2D()
        {
        }
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
