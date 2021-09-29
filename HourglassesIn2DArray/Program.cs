using System;
using System.Collections.Generic;

namespace HourglassesIn2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = Utilities.Creat6x6Array();
            //var a = Utilities.Creat6x6ArrayRandom();
            var a = Utilities.Create6x6HardcodedTest01(); 

            Utilities.Print2DArray(a);
            Console.WriteLine("\r\nMax hourglasses Sum = " +  HourglassArrayMethods.GetMaxHourglassesSum(a));
            Console.WriteLine();


            Console.WriteLine(" ==============  List<List<int>> to int[,] conversion game ===============");
            List<List<int>> arr = Utilities.Convert2DArrayToListInList(a);

            var a2 = Utilities.ConvertListInListTo2DArray(arr);
            Utilities.Print2DArray(a2);

            Console.WriteLine("\r\nMax hourglasses Sum  of List<List<int>> = " + HourglassArrayMethods.hourglassSum(arr));
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
