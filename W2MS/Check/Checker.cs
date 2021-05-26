using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W2MS.Sort;

namespace W2MS.Check
{
    public class Checker
    {

        public static void Check(Action<int[]> func)
        {
            int testTime = 500;
            int size = 10;
            int value = 100;
            bool succeed = true;
            for (int i = 0; i < testTime; i++)
            {
                int[] arr1 = generateRandomArray(size, value);
                int[] arr2 = (int[])(arr1.Clone());
                int[] arr3 = (int[])(arr1.Clone());
                func(arr2);
                arr3= rightMethod(arr3);
                if (!isEqual(arr2, arr3))
                {
                    succeed = false;
                    SortBase.Print(arr1);
                    break;
                }
            }
            Console.WriteLine(succeed ? "Nice!" : "error----");
            //int[] arr = generateRandomArray(size, value);
            //printArray(arr);
            //bubbleSort(arr);
            //printArray(arr);

        }

        // 判断两个数组是否相等
         static bool isEqual(int[] arr1, int[] arr2)
        {
            if ((arr1 == null && arr2 != null) || (arr1 != null && arr2 == null))
                return false;
            if (arr1 == null && arr2 == null)
                return true;
            if (arr1.Length != arr2.Length)
                return false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }
        // 随机数生成器
         static int[] generateRandomArray(int size, int value)
        {
            //Math.random() -> double [0,1)
            //(int) ((size + 1) * Math.random()) -> [0,size]整数
            // 生成长度随机[0, size]的数组
            Random random = new Random();
            int[] arr = new int[(int)((size + 1) * random.Next(10,100))];
            for (int i = 0; i < arr.Length; i++)
            {
                // 一个随机数减去另一个随机数，生成[-value, value]的随机数
                arr[i] = (int)((value + 1) * random.Next(10, 100)) - (int)(value * random.Next(10, 100));
            }
            return arr;
        }

        public static int[] rightMethod(int[] arr)
        {
            var list = arr.ToList();
            list.Sort();
            return list.ToArray();
        }
    }
}
