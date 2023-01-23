using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Adventures.Container
{
    public class SortingMethods
    {
        /// <summary>
        /// Insert sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        public void insertSort(int[] numbers)
        {
            int number;
            int i;

            for (int j = 1; j < numbers.Length; j++)
            {
                number = numbers[j];
                i = j - 1;
                while (i > -1 && numbers[i] < number)
                {
                    numbers[i + 1] = numbers[i];
                    i--;
                }
                numbers[i + 1] = number;
            }
        }
        /// <summary>
        /// Merge sort algorithm.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
        public void mergeSort(int[] numbers, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            List<int> L = new List<int>();
            List<int> R = new List<int>();

            for (int n = 0; n < n1; n++)
            {
                L.Add(numbers[p + n]);
            }

            for (int m = 0; m < n2; m++)
            {
                R.Add(numbers[q + m + 1]);
            }

            int i = 0;
            int j = 0;
            for (int k = p; k < r; k++)
            {
                if (L[i] <= R[j])
                {
                    numbers[k] = L[i];
                    i++;
                }
                else
                {
                    numbers[k] = R[j];
                    j++;
                }
            }
        }
    }
}
