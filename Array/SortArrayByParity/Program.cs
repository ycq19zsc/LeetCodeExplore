using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = new int[] { 1, 2, 3, 4 };

            (arr[0], arr[1]) = (arr[1], arr[0]);

            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }

        static int[] SortArrayByParity(int[] A)
        {

            var evenItems = new List<int>();
            var oddItems = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    evenItems.Add(A[i]);
                }
                else
                {
                    oddItems.Add(A[i]);
                }
            }

            return evenItems.Concat(oddItems).ToArray();
        }
        static int[] SortArrayByParity2(int[] A)
        {
            var items = new List<int>();

            foreach (var item in A)
            {
                if (item % 2 == 0)
                {
                    items.Insert(0, item);
                }
                else
                {
                    items.Add(item);
                }
            }

            return items.ToArray();
        }
    }
}
