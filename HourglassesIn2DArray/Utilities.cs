using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HourglassesIn2DArray
{
    public class Utilities
    {
        public static int[,] Creat6x6Array()
        {
            var a = new int[6,6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = i;
                }
            }

            return a;
        }


        // values from -9 to +9
        public static int[,] Creat6x6ArrayRandom()
        {
            var a = new int[6, 6];
            var rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = rand.Next(-9,9);
                }
            }

            return a;
        }

        public static int[,] Create6x6HardcodedTest02()
        {
            return new int[6, 6]
                {
                   {1, 1, 1, 0, 0, 0},
                   {0, 1, 0, 0, 0, 0},
                   {1, 1, 1, 0, 0, 0},
                   {0, 0, 2, 4, 4, 0},
                   {0, 0, 0, 2, 0, 0},
                   {0, 0, 1, 2, 4, 0},
                };
        }

        public static int[,] Create6x6HardcodedTest01()
        {
            return new int[6, 6]
                {
                   {1, 1, 1, 0, 0, 0},
                   {0, 1, 0, 0, 0, 0},
                   {1, 1, 1, 0, 0, 0},
                   {0, 0, 2, 4, 4, 0},
                   {0, 0, 0, 2, 0, 0},
                   {0, 0, 1, 2, 4, 0},
                };
        }

        public static void Print2DArray(int[,] a)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($" {a[i,j], 5}");
                }
                Console.WriteLine();
            }
        }


        //public static int[,] ConvertListListToArrayInArray(List<List<int>> arr)
        //{
        //    int[,] a = arr.Select(a => a.ToArray()).ToArray();
        //    return a;
        //}

        public static int[,] ConvertListInListTo2DArray(List<List<int>> arr)
        {
            var a = new int[6, 6];  // let's assume we know dimentions, or we should iterate through lists to calculate 

            int i = 0;
            foreach (var x in arr)
            {
                int j = 0;
                foreach (var y in x)
                {
                    a[i, j] = y;
                    j++;
                }
                i++;
            }

            return a;
        }

        public static List<List<int>>  Convert2DArrayToListInList(int[,] a)
        {
            var arr = new List<List<int>>();
            var lenX = a.GetLength(0);
            var lenY = a.GetLength(1);

            for (int i = 0; i < lenX; i++)
            {
                var l = new List<int>();
                for (int j = 0; j < lenY; j++)
                {
                    l.Add(a[i, j]);
                }
                arr.Add(l);
            }

            return arr;
        }
    }
}
