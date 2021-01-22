using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Round : Figure
    {
        const double Pi = 3.14;
        public Round(double r)
        {
            Radius = r;
            if (Radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным");
        }
        public double Radius { get; set; }
        public override double GetArea() => Radius * Radius * Pi;
    }
}
