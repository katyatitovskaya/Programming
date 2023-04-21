using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return Math.Abs(rectangle1.Centre.X - rectangle2.Centre.X) < rectangle1.Width / 2 + rectangle2.Width / 2
                && Math.Abs(rectangle1.Centre.Y - rectangle2.Centre.Y) < rectangle1.Length / 2 + rectangle2.Length / 2;
        }
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double x_s = Math.Abs(ring1.Centre.X - ring2.Centre.X);
            double y_s = Math.Abs(ring1.Centre.Y - ring2.Centre.Y);
            return Math.Sqrt(Math.Pow(x_s, 2) + Math.Pow(y_s, 2)) < ring1.OuterRadius + ring2.OuterRadius;
        }
    }
}
