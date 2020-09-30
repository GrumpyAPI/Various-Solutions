using System;
using System.Collections.Generic;
using System.Text;

namespace Point_in_Rectangle
{
    public class Rectangle
    {
        public Rectangle(int top, int bottom, int left, int right)
        {
            this.TopLeftCoordinates = new Point(left, top);
            this.BottomRightCoordinates = new Point(right, bottom);
        }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeftCoordinates = topLeft;
            this.BottomRightCoordinates = bottomRight;
        }

        public Point TopLeftCoordinates { get; set; }

        public Point BottomRightCoordinates { get; set; }

        public bool Contains(Point point)
        {
            bool isInX = point.X >= TopLeftCoordinates.X && point.X <= BottomRightCoordinates.X;
            bool isInY = point.Y <= TopLeftCoordinates.Y && point.Y >= BottomRightCoordinates.Y;

            return isInX && isInY;
        }
    }
}
