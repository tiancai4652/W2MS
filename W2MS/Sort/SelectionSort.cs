using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Sort
{
    /// <summary>
    /// 
    /// </summary>
    public class SelectionSort: SortBase
    {
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var index= GetMinIndex(array,i);
                Swap(array, i, index);
            }
        }

        public static int GetMinIndex(int[] array,int start)
        {
            int index = start;
            for (int i = start; i < array.Length-1; i++)
            {
                if (array[index] > array[i + 1])
                {
                    index = i + 1;
                }
            }
            return index;
        }

       
    }
}
