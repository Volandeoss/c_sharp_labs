using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sharp
{
    public struct Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X;
        public double Y;

        public override string ToString() => $"({X}, {Y})";
    }

    public abstract class Shape
    {
        public abstract double Area { get;}

        protected static void getCoords(ref Point p)
        {
            bool isValid = false;
            Point localPoint = new Point();

            while (!isValid)
            {
                try
                {
                    Console.WriteLine("");
                    Console.Write("X = ");
                    localPoint.X = double.Parse(Console.ReadLine());
                    Console.Write("Y = ");
                    localPoint.Y = double.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("ВВЕДІТЬ ПРАВИЛЬНІ ДАННІ!!");
                }
            }

            p.X = localPoint.X;
            p.Y = localPoint.Y;
        }
        public abstract void InitCoords();
    }

    public class Triangle : Shape
    {
        protected Point A, B, C;

        public override double Area
        {
            get
            {
                return 0.5 * Math.Abs(
                    A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)
                    );
            }
        }

        public override void InitCoords()
        {
            Console.Write("Введiть координати точки А");
            getCoords(ref this.A);
            Console.Write("Введiть координати точки B");
            getCoords(ref this.B);
            Console.Write("Введiть координати точки C");
            getCoords(ref this.C);
        }

        public override string ToString() => $"A{A} B{B} C{C}";
    }

    public class СonQuad : Triangle
    {
        Point D;

        public override double Area
        {
            get
            { 
                return 0.5 * Math.Abs((A.X*B.Y+B.X*C.Y+C.X*D.Y+D.X*A.Y)-(B.X*A.Y+C.X*B.Y+D.X*C.Y+A.X*D.Y));
            }
        }

        public override void InitCoords()
        {
            base.InitCoords();
            Console.Write("Введіть координати точки D");
            getCoords(ref this.D);
        }

        public override string ToString() => $"{base.ToString()} D{D}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle();
            t.InitCoords();
            Console.WriteLine(t);
            Console.WriteLine(t.Area);

            СonQuad q = new СonQuad();
            q.InitCoords();
            Console.WriteLine(q);
            Console.WriteLine(q.Area);
        }
    }
}
