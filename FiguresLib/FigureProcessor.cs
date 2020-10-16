using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FiguresLib.Figures;

namespace FiguresLib
{
    public class FigureProcessor
    {
        public static double DistanceBetweenPoint(int X1, int Y1, int X2, int Y2)
        {
            return Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
        }
        public static double Angle(int x1, int y1, int x2, int y2)
        {
            int x = x2 - x1;
            int y = y2 - y1;

            if (x == 0)
                return 0;
            else
                return y / x;
        }

        public static bool ChekIfQuadrate(int[] points)
        {
            double DistanceAB = DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            /////////////////////////////////////

            double DistanceAC = DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBD = DistanceBetweenPoint(points[2], points[3], points[6], points[7]);
            return (DistanceAB == DistanceCD && DistanceBC == DistanceDA && DistanceCD == DistanceBC && DistanceAC == DistanceBD);
        }
        public static bool ChekIfRhombus(int[] points)
        {
            double DistanceAB = DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            /////////////////////////////////////

            double DistanceAC = DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBD = DistanceBetweenPoint(points[2], points[3], points[6], points[7]);
            return (DistanceAB == DistanceCD && DistanceBC == DistanceDA && DistanceCD == DistanceBC && DistanceAC != DistanceBD);
        }
        public static bool ChekIfTrapezoid(int[] points)
        {
            double angleAB = Angle(points[0], points[1], points[2], points[3]);
            double angleBC = Angle(points[2], points[3], points[4], points[5]);
            double angleCD = Angle(points[4], points[5], points[6], points[7]);
            double angleDA = Angle(points[6], points[7], points[0], points[1]);
            return (angleAB != angleCD && angleBC == angleDA);
        }
        public static bool ChekIfRecangl(int[] points)
        {
            double DistanceAB = DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            /////////////////////////////////////

            double DistanceAC = DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBD = DistanceBetweenPoint(points[2], points[3], points[6], points[7]);
            return (DistanceAB == DistanceCD && DistanceBC == DistanceDA && DistanceAC == DistanceBD);
        }
        public static bool ChekIfParallelepiped(int[] points)
        {
            double DistanceAB = DistanceBetweenPoint(points[0], points[1], points[2], points[3]);
            double DistanceBC = DistanceBetweenPoint(points[2], points[3], points[4], points[5]);
            double DistanceCD = DistanceBetweenPoint(points[4], points[5], points[6], points[7]);
            double DistanceDA = DistanceBetweenPoint(points[6], points[7], points[0], points[1]);

            /////////////////////////////////////

            double DistanceAC = DistanceBetweenPoint(points[0], points[1], points[4], points[5]);
            double DistanceBD = DistanceBetweenPoint(points[2], points[3], points[6], points[7]);
            return (DistanceAB == DistanceCD && DistanceBC == DistanceDA && DistanceAC != DistanceBD);
        }
        //фигура наибольшей площади
        public double GreatestSquareForType(Figure[] allFigures, string type)
        {
            double maxSquares = 0;
            double squares;
            for (int i = 0; i < allFigures.Length; i++)
            {
                if (allFigures[i].Type == type)
                {
                    squares = allFigures[i].GetSquare(allFigures[i].Points);
                    if (maxSquares < squares)
                    {
                        maxSquares = squares;
                    }
                }
            }
            return maxSquares;
        }
        public string FindGreatestSquare(Figure[] allFigures)
        {
            double[] squares = {
                GreatestSquareForType(allFigures, "circle"),
                GreatestSquareForType(allFigures, "triangle"),
                GreatestSquareForType(allFigures, "parallelepiped"),
                GreatestSquareForType(allFigures, "quadrate"),
                GreatestSquareForType(allFigures, "trapezoid"),
                GreatestSquareForType(allFigures, "rhombus"),
                GreatestSquareForType(allFigures, "rectangl")
            };
            double max = 0;
            int tmpI = -1;
            for (int i = 0; i < squares.Length; i++)
            {
                if (max < squares[i])
                {
                    max = squares[i];
                    tmpI = i;
                }
            }
            if (tmpI == 0)
                return "circle";
            else if (tmpI == 1)
                return "triangle";
            else if (tmpI == 2)
                return "parallelepiped";
            else if (tmpI == 3)
                return "quadrate";
            else if (tmpI == 4)
                return "trapezoid";
            else if (tmpI == 5)
                return "rhomdus";
            else if (tmpI == 6)
                return "rectangl";
            else
                return "Error";

        }
        ///////////
        //средняя площадь
        public double MiddleSquare(Figure[] allFigures)
        {
            double[] squares = new double[allFigures.Length];
            for (int i = 0; i < allFigures.Length; i++)
            {
                squares[i] = allFigures[i].GetSquare(allFigures[i].Points);
            }
            double sum = squares.Sum();
            return sum / allFigures.Length;
        }
        //средний периметер
        public double MiddlePerimeter(Figure[] allFigures)
        {
            double[] perimeter = new double[allFigures.Length];
            for (int i = 0; i < allFigures.Length; i++)
            {
                perimeter[i] = allFigures[i].GetPerimeter(allFigures[i].Points);
            }
            double sum = perimeter.Sum();
            return sum / allFigures.Length;
        }
        //тип фигуры с наибольшим средним периметром
        public double MiddlePerimeterForType(Figure[] allFigures, string type)
        {
            double[] perimeter = new double[allFigures.Length];
            int count = 0;
            for (int i = 0; i < allFigures.Length; i++)
            {
                if (allFigures[i].Type == type)
                {
                    perimeter[i] = allFigures[i].GetPerimeter(allFigures[i].Points);
                    count++;
                }
            }
            double sum = perimeter.Sum();
            return sum / count;
        }
        public string FindGreatestMiddlePerimeter(Figure[] allFigures)
        {
            double[] perimeter = {
                MiddlePerimeterForType(allFigures, "circle"),
                MiddlePerimeterForType(allFigures, "triangle"),
                MiddlePerimeterForType(allFigures, "parallelepiped"),
                MiddlePerimeterForType(allFigures, "quadrate"),
                MiddlePerimeterForType(allFigures, "trapezoid"),
                MiddlePerimeterForType(allFigures, "rhomdus"),
                MiddlePerimeterForType(allFigures, "rectangl")
            };
            double max = 0;
            int tmpI = -1;
            for (int i = 0; i < perimeter.Length; i++)
            {
                if (max < perimeter[i])
                {
                    max = perimeter[i];
                    tmpI = i;
                }
            }
            if (tmpI == 0)
                return "circle";
            else if (tmpI == 1)
                return "triangle";
            else if (tmpI == 2)
                return "parallelepiped";
            else if (tmpI == 3)
                return "quadrate";
            else if (tmpI == 4)
                return "trapezoid";
            else if (tmpI == 5)
                return "rhomdus";
            else if (tmpI == 6)
                return "rectangl";
            else
                return "Error";

        }
    }
}
