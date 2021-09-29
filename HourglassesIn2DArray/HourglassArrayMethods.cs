using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HourglassesIn2DArray
{
    public class HourglassArrayMethods
    {
        public static int GetVerticalHourglassSum(int[,] a, int x, int y)
        {
            var s = a[y,x]         + a[y,x + 1]          + a[y,x + 2]
                                   + a[y + 1, x + 1]     +
                  +a[y + 2, x]     + a[y + 2, x + 1]     + a[y + 2, x + 2];

            return s;
        }


        // all depends how we "rotate" matrix
        public static int GetHorizontalHourglassSum(int[,] a, int x, int y)
        {
            var s = a[x,y]      + a[x+1, y]     + a[x+2, y]  
                                + a[x+1, y+1]   +
                  + a[x, y+2]   + a[x+1, y+2]   + a[x+2, y+2];

            return s;
        }

        // first X have 0,0 coordinates
        // last  X have 3,3 coordinates
        public static int GetMaxHourglassesSum(int[,] a)
        {
            int max = -9 * 7 - 1; // impossible lovest
            Console.WriteLine($" Initial impossible Sum = {max,10} ");

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    int s = GetVerticalHourglassSum(a, i, j);

                    Console.Write($" Sum = {s,10} ");

                    if (s > max)
                        max = s;
                }
            }

            return max;
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            var a = Utilities.ConvertListInListTo2DArray(arr);
            return GetMaxHourglassesSum(a);
        }

    }
}
