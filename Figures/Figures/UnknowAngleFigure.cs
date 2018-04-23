using Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Figures
{
    public class UnknownAngleFigure : IArea
    {
        Coordinate[] Coordinates { get; set; }

        public UnknownAngleFigure(params Coordinate[] coordinates)
        {
            Coordinates = coordinates;
        }

        public double GetArea()
        {
            double positiveResult = 0;
            double negativeResult = 0;

            for(int i = 0; i<(Coordinates.Length - 1); i++)
            {
                positiveResult += Coordinates[i].X * Coordinates[i + 1].Y + Coordinates[Coordinates.Length - 1].X * Coordinates[0].Y;
                negativeResult += Coordinates[i+1].X * Coordinates[i].Y - Coordinates[0].X * Coordinates[Coordinates.Length - 1].Y;
            }

            double result = Math.Abs(positiveResult - negativeResult) / 2;

            return result;
        }
    }
}
