using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Sort
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort : SortBase
    {
        public static void Sort(int[] array)
        {
            for (int length = array.Length - 1; length >1 ; length--)
            {
                for (int i = 0; i < length; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
            Print(array);
        }
    }
}
