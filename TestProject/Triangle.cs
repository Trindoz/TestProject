using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Triangle : Figure
    {
        private double a, b, c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Сторона треугольника должна быть положительной");
            if (a >= b + c)
                throw new ArgumentException("Невозможно создать треугольник со стороной a");
            if (b >= a + c)
                throw new ArgumentException("Невозможно создать треугольник со стороной b");
            if (c >= b + a)
                throw new ArgumentException("Невозможно создать треугольник со стороной c");
        }
        public double Perimetr { get { return a + b + c; } private set { } }
        public bool IsSquared()
        {
            List<double> sides = new List<double> { a, b, c };
            sides.Sort();
            return sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1];
        }
        public override double GetArea() => Math.Sqrt(Perimetr / 2 * (Perimetr / 2 - a) * (Perimetr / 2 - b) * (Perimetr / 2 - c));
    };
}
