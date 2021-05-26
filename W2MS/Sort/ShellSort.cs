using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2MS.Sort
{
    public class ShellSort: SortBase
    {
        public static void Sort(int[] array)
        {

            int gap = 1;

            while (array.Length>gap)
            {
                gap = gap * 3 + 1;
            }
            if (gap > array.Length)
            {
                gap = (gap - 1) / 3;
            }


            while (gap != 1)
            {
                int initValue = 0;
                while (gap >= initValue)
                {
                    for (int i = initValue; i < array.Length; i += gap)
                    {
                        int current = i;
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (array[j] > array[current])
                            {
                                Swap(array, current, j);
                                current = j;
                            }
                        }
                    }
                    initValue++;
                }
                gap = (gap - 1) / 3;
            }


        }
    }
}
