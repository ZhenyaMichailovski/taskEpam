using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Rhombus : Figure
    {
        public Rhombus(int[] points, string type)
           : base(points, type)
        { }
        public override double GetSquare(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);

            int A1 = points[2] - points[0];
            int B1 = points[3] - points[1];
            int A2 = points[6] - points[0];
            int B2 = points[7] - points[1];

            double angle = Angle(A1, B1, A2, B2);
            double Square = angle * DistanceAB * DistanceAB;

            return Square;
        }
        public override double GetPerimeter(int[] points)
        {
            double DistanceAB = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);

            double Perimeter = DistanceAB * 4;

            return Perimeter;
        }
        public double Angle(int A1, int B1, int A2, int B2)
        {
            double a = (A1 * B1 + B1 * B2) / (Math.Sqrt(Math.Pow(A1, 2) + Math.Pow(B1, 2)) * Math.Sqrt(Math.Pow(A2, 2) + Math.Pow(B2, 2)));
            return a;
        }
    }
}
