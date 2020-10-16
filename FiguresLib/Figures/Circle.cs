using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public class Circle : Figure
    {
        public Circle(int[] points, string type)
           : base(points, type)
        { }

        public override double GetSquare(int[] points)
        {
            double Radius = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double Square = Math.PI * Math.Pow(Radius, 2);
            return Square;
        }
        public override double GetPerimeter(int[] points)
        {

            double Radius = FigureProcessor.DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double Perimeter = Math.PI * Radius * 2;
            return Perimeter;
        }
    }
}