using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Sort
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class InsertSort: SortBase
    {
        public static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                InsertAndSort(array, i);
            }
        }

        static void InsertAndSort(int[] arraySorted, int index)
        {
            //从后往前交换
            for (int i = index - 1; i >= 0; i--)
            {
                if (arraySorted[index] < arraySorted[i])
                {
                    Swap(arraySorted,index,i);
                    index = i;
                }
            }



            //插入到前面，后面的数据后移一位
            //for (int i = 0; i < index - 1; i++)
            //{
            //    if (arraySorted[i] > arraySorted[index])
            //    {
            //        var temp = arraySorted[index];
            //        while (index > i)
            //        {
            //            arraySorted[index] = arraySorted[index - 1];
            //            index--;
            //        }
            //        arraySorted[i] = temp;
            //    }
            //}
        }
    }
}
