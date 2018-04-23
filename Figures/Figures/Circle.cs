using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class Circle : IArea
    {
        private const double pi = 3.14;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Радиус должен быть положительным числом");

            Radius = radius;
        }
        public double GetArea() => pi * Math.Pow(Radius, 2);
    }
}
