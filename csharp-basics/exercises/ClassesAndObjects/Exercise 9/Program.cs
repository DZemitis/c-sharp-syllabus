using System;

namespace Exercise_9
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int pointX, int pointZ)
        {
            X = pointX;
            Y = pointZ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            SwapPoints(p1, p2);

            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");

        }

        public static void SwapPoints(Point x, Point z)
        {
            var (X, Y) = (x.X, x.Y);
            (x.X, x.Y) = (z.X, z.Y);
            (z.X, z.Y) = (X, Y);
        }
    }
}
