using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class Triangle : IArea
    {
        public IEnumerable<double> Sides { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Sides = new List<double>() { side1, side2, side3 };

            if (Sides.Any(t => t <= 0))
                throw new Exception("Длина стороны должна быть положительным числом");
        }
        public double GetArea()
        {
            double halfPerimeter = Sides.Sum() / 2;

            double accumulatingValues = Sides
                .Select(t => halfPerimeter - t)
                .Aggregate((a,t) => a * t);

            double result = Math.Sqrt(accumulatingValues * halfPerimeter);

            return result;
        }

        public bool IsRectangular()
        {
            double[] sides = Sides.ToArray();

            for(int i =0; i<= 2; i++)
            {
                var hypotenuse = sides[i];
                double accumulKattes = 0;

                for(int k = 0; k <= 2; k++)
                {
                    if (i != k)
                        accumulKattes += Math.Pow(sides[k], 2);
                }

                if (Math.Pow(hypotenuse, 2) == accumulKattes)
                    return true;
            }

            return false;
        }
    }
}
