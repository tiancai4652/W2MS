using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Offical
{
	public class Code01_SelectionSort: Code01_Base
	{

		public static void selectionSort(int[] arr)
		{
			if (arr == null || arr.Length < 2)
			{
				return;
			}
			// 0 ~ N-1
			// 1~n-1
			// 2
			for (int i = 0; i < arr.Length - 1; i++)
			{ // i ~ N-1
			  // 最小值在哪个位置上  i～n-1
				int minIndex = i;
				for (int j = i + 1; j < arr.Length; j++)
				{ // i ~ N-1 上找最小值的下标 
					minIndex = arr[j] < arr[minIndex] ? j : minIndex;
				}
				swap(arr, i, minIndex);
			}
		}


    

	}
}
