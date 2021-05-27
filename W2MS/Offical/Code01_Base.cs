using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Offical
{
   public class Code01_Base
    {
		public static void swap(int[] arr, int i, int j)
		{
			int tmp = arr[i];
			arr[i] = arr[j];
			arr[j] = tmp;
		}

		// for test
		public static void comparator(int[] arr)
		{
			Array.Sort(arr);
		}

		// for test
		public static int[] generateRandomArray(int maxSize, int maxValue)
		{
			// Math.random()   [0,1)  
			// Math.random() * N  [0,N)
			// (int)(Math.random() * N)  [0, N-1]
			Random random = new Random();
			int[] arr = new int[(int)((maxSize + 1) * random.Next(0, 1))];
			for (int i = 0; i < arr.Length; i++)
			{
				// [-? , +?]
				arr[i] = (int)((maxValue + 1) * random.Next(0, 1)) - (int)(maxValue * random.Next(0, 1));
			}
			return arr;
		}

		// for test
		public static int[] copyArray(int[] arr)
		{
			if (arr == null)
			{
				return null;
			}
			int[] res = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				res[i] = arr[i];
			}
			return res;
		}

		// for test 对数器
		public static bool isEqual(int[] arr1, int[] arr2)
		{
			if ((arr1 == null && arr2 != null) || (arr1 != null && arr2 == null))
			{
				return false;
			}
			if (arr1 == null && arr2 == null)
			{
				return true;
			}
			if (arr1.Length != arr2.Length)
			{
				return false;
			}
			for (int i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] != arr2[i])
				{
					return false;
				}
			}
			return true;
		}

		// for test
		public static void printArray(int[] arr)
		{
			if (arr == null)
			{
				return;
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i] + " ");
			}
			Console.WriteLine(Environment.NewLine);
		}

		// for test
		public static void main(String[] args)
		{
			int testTime = 500000;
			int maxSize = 100;
			int maxValue = 100;
			bool succeed = true;
			for (int i = 0; i < testTime; i++)
			{
				int[] arr1 = generateRandomArray(maxSize, maxValue);
				int[] arr2 = copyArray(arr1);
				selectionSort(arr1);
				comparator(arr2);
				if (!isEqual(arr1, arr2))
				{
					succeed = false;
					printArray(arr1);
					printArray(arr2);
					break;
				}
			}
			Console.WriteLine(succeed ? "Nice!" : "Fucking fucked!");

			int[] arr = generateRandomArray(maxSize, maxValue);
			printArray(arr);
			selectionSort(arr);
			printArray(arr);
		}

	}
}
