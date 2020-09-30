using System;
using System.Collections.Generic;
using System.Text;

namespace Point_in_Circle
{
    public class Circle
    {
        public Circle(int x, int y, int radius)
        {
            this.Center = new Point(x, y);
            this.Radius = radius;
        }

        public Point Center { get; set; }

        public int Radius { get; set; }

        public bool Contains(Point point)
        {
            var distance = Math.Sqrt((point.X - this.Center.X) * (point.X - this.Center.X) + (point.Y - this.Center.Y) * (point.Y - this.Center.Y));

            return distance <= this.Radius; // Instead of using if else.
        }
    }
}
