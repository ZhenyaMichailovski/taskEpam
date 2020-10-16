using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Trapezoid : Figure
    {
        public Trapezoid(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = FigureProcessor.DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = FigureProcessor.DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            double square;
            square = ((DistanceBC + DistanceDA) / 2) * Math.Sqrt(Math.Pow(DistanceAB, 2) - Math.Pow((Math.Pow((DistanceDA - DistanceBC), 2) + Math.Pow(DistanceAB, 2) - Math.Pow(DistanceCD, 2)) / (2 * (DistanceDA - DistanceBC)) , 2));
            return square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = FigureProcessor.DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = FigureProcessor.DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            double Perimeter = DistanceAB + DistanceBC + DistanceCD + DistanceDA;

            return Perimeter;
        }
      
    }
}
