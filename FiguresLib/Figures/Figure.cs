using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLib.Figures
{
    public abstract class Figure
    {
        public int[] Points { get; protected set; }
        public string Type { get; protected set; }

        public Figure(int[] points, string type)
        {
            Points = points;
            Type = type;
        }
        public abstract double GetSquare(int[] points);
        public abstract double GetPerimeter(int[] points);

    }
}
