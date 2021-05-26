using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Sort
{
    public class SortBase
    {
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Print(int[] array)
        {
            string str = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            Console.WriteLine(str);
        }
    }
}
