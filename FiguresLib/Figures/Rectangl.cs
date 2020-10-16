using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Rectangl : Figure
    {
        public Rectangl(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);

            double Square = DistanceAB * DistanceBC;

            return Square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);

            double Perimeter = (DistanceAB * DistanceBC) * 2;

            return Perimeter;
        }
       
    }
}
