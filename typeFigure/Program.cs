using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using FiguresLib;
using FiguresLib.Figures;

namespace typeFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteTask();
            Console.ReadKey();
        }

        public static void ExecuteTask()
        {
            List<int[]> list = FileProcessor.FromFileToArray("../../text.txt");
            Figure[] figure = new Figure[list.Count];
            int i = 0;
            foreach(int[] one in list)
            {
                if (one.Length == 4)
                    figure[i] = new Circle(one, "circle");
                else if (one.Length == 6)
                    figure[i] = new Triangle(one, "triangle");
                else if (one.Length == 8)
                {
                   if(FigureProcessor.ChekIfQuadrate(one))
                   {
                        figure[i] = new Quadrate(one, "quadrate");
                   }
                   else if (FigureProcessor.ChekIfRhombus(one))
                   {
                        figure[i] = new Rhombus(one, "rhombus");
                   }
                   else if(FigureProcessor.ChekIfParallelepiped(one))
                   {
                        figure[i] = new Parallelepiped(one, "parallelepiped");
                   }
                   else if(FigureProcessor.ChekIfRecangl(one))
                   {
                        figure[i] = new Rectangl(one, "rectangl");
                   }
                   else if(FigureProcessor.ChekIfTrapezoid(one))
                   {
                        figure[i] = new Rectangl(one, "trapezoid");
                   }
                }

                i++;
            }

            FigureProcessor figureProcessor = new FigureProcessor();
            Console.WriteLine("Тип фигуры с наибольшим средним периметром: " + figureProcessor.FindGreatestMiddlePerimeter(figure));
            Console.WriteLine("Cредний периметр всех фигур: " + figureProcessor.MiddlePerimeter(figure) + "\nСредняя площадь всех фигур: " + figureProcessor.MiddleSquare(figure));
            Console.WriteLine("Фигура наибольшей площади: " + figureProcessor.FindGreatestSquare(figure));
        }
    }
}
