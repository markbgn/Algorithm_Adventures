using Algorithm_Adventures.Container;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Adventures
{
    internal class Program
    {
        static void Main()
        {
            SortingMethods sorting = new SortingMethods();
            // Array to sort
            int[] numbers = { 1, 7, 9, 10, 13, 16, 4, 5, 11, 14, 22 };

            // Creating arrays without reference
            int[] numbersInsert = numbers.ToArray();
            int[] numbersMerge = numbers.ToArray();

            // Insertion sort
            sorting.insertSort(numbersInsert);

            Console.WriteLine("Numbers sorted with insertion sort:");
            Console.WriteLine(string.Join(" ", numbersInsert));

            // Merge sort
            sorting.mergeSort(numbersMerge, 0, 5, numbersMerge.Length-1);

            Console.WriteLine("Numbers sorted with merge sort:");
            Console.WriteLine(string.Join(" ", numbersMerge));

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                //run loop until Enter is pressed
            }
        }
    }
}
