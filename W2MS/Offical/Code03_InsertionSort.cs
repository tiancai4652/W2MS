using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Offical
{
	public class Code03_InsertionSort: Code01_Base
	{

		public static void insertionSort(int[] arr)
		{
			if (arr == null || arr.Length < 2)
			{
				return;
			}
			// 0~0 有序的
			// 0~i 想有序
			for (int i = 1; i < arr.Length; i++)
			{ // 0 ~ i 做到有序
				for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
				{
					swap(arr, j, j + 1);
				}
			}
		}
	}
	}
