using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FiguresLib
{
    public class FileProcessor
    {
        public static List<int[]> FromFileToArray(string path)
        {
            List<int[]> figuresPoints = new List<int[]>();
            int[] arr = null;

            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                string[] elements;

                while ((line = sr.ReadLine()) != null)
                {
                    elements = line.Split(' ');

                    if (elements.Length % 2 != 0)
                    {
                        Console.WriteLine("Нечетное кол-во координат в строке.");
                    }
                    else
                    {
                        arr = new int[elements.Length];
                        int i = 0;
                        foreach (string s in elements)
                        {
                            if (s != "")
                            {
                                arr[i] = int.Parse(s);
                                i++;
                            }
                        }
                    }

                    figuresPoints.Add(arr);
                }

                return figuresPoints;
            }
        }

    }
}
