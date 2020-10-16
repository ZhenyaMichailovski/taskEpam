using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Triangle : Figure
    {
        public Triangle(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double Square = 0;
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceAC = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double HalfPerimeter = 0;
            HalfPerimeter = (DistanceAB + DistanceAC + DistanceBC) / 2;

            Square = Math.Pow((HalfPerimeter * (HalfPerimeter - DistanceAB) * (HalfPerimeter - DistanceAC) * (HalfPerimeter - DistanceBC)), 1 / 2.0);

            return Square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceAC = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);

            double Perimeter = 0;
            Perimeter = DistanceAB + DistanceAC + DistanceBC;

            return Perimeter;
        }
       
    }
}
