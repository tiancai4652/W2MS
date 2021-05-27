using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Offical
{
	public class Code02_BubbleSort: Code01_Base
	{

		public static void bubbleSort(int[] arr)
		{
			if (arr == null || arr.Length < 2)
			{
				return;
			}
			// 0 ~ N-1
			// 0 ~ N-2
			// 0 ~ N-3
			for (int e = arr.Length - 1; e > 0; e--)
			{ // 0 ~ e
				for (int i = 0; i < e; i++)
				{
					if (arr[i] > arr[i + 1])
					{
						swap(arr, i, i + 1);
					}
				}
			}
		}

	}
}
