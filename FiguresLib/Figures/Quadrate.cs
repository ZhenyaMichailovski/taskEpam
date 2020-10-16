using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Quadrate : Figure
    {
        public Quadrate(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);

            double Square = DistanceAB * DistanceAB;

            return Square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);

            double Perimeter = DistanceAB * 4;

            return Perimeter;
        }
    }
}
