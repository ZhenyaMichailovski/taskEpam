using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Parallelepiped : Figure
    {
        public Parallelepiped(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceAD = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[6], points[7]);

            int A1 = points[2] - points[0];
            int B1 = points[3] - points[1];
            int A2 = points[6] - points[0];
            int B2 = points[7] - points[1];

            double angle = Angle(A1, B1, A2, B2);
            double Square = angle * DistanceAB * DistanceAD;

            return Square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = FigureProcessor.DistanceBetweenPoint(points[2], points[3], points[4], points[5]);

            double Perimeter = (DistanceAB * DistanceBC) * 2;

            return Perimeter;
        }
        public double Angle(int A1, int B1, int A2, int B2)
        {
            double a = (A1 * B1 + B1 * B2) / (Math.Sqrt(Math.Pow(A1, 2) + Math.Pow(B1, 2)) * Math.Sqrt(Math.Pow(A2, 2) + Math.Pow(B2, 2)));
            return a;
        }
       
    }
}
