using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Ring
    {
        private double _innerradius;
        private double _outerradius;

        public Point2D Centre { get; set; }
        public double InnerRadius
        {
            get => _innerradius;
            private set
            {
                Validator.AssertValueInRange(value, 0, OuterRadius);
                _innerradius = value;
            }
        }
        public double OuterRadius
        {
            get => _outerradius;
            private set
            {
                Validator.AssertValueInRange(value, InnerRadius, double.MaxValue);
                _outerradius = value;
            }
        }
        private static double Area(Ring ring)
        {
            double area = 3.14*(Math.Pow(ring.OuterRadius, 2))-3.14*(Math.Pow(ring.InnerRadius, 2));
            return area;
        }
        public static int AllRingsCount { get; set; }
        public int Id { get; }
        public Ring(double outerRadius, double innerRadius, int x, int y)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
            Centre = new Point2D(x, y);
            Id = AllRingsCount;
            AllRingsCount++;
        }
        public Ring()
        {
        }
    }
}
