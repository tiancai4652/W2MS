﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W2MS.Check;
using W2MS.Sort;

namespace W2MS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, 2, 6, 0, 1, 3, 7, 8 };

            Checker.rightMethod(array);
            //SelectionSort.Sort(array);
            //BubbleSort.Sort(array);
            //InsertSort.Sort(array);

            Checker.Check(InsertSort.Sort);

            Console.ReadKey();

        }
    }
}
