using System;
using System.Threading.Channels;

namespace OOP
{
    public abstract class Shapes
    {

        public Shapes()
        {
            Console.WriteLine("Shape created");
        }

        public abstract void Draw();

        public abstract double Aria();

        public abstract double Perimeter();
    }

    public class Rectangle : Shapes
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("Rectangle created");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }

        public override double Aria()
        {
            return width * height;
        }

        public override double Perimeter()
        { 
            return 2 * (width + height);
        }
    }

    public class Triangle : Shapes
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;
            Console.WriteLine("Triangle created");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }

        public override double Aria()
        {
            double s = (ab + bc + ac) / 2;
            return Math.Sqrt(s* (s - ab) * (s -bc) * (s - ac));
        }

        public override double Perimeter()
        {
            return ab + bc + ac;
        }
    }

}