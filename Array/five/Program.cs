using System;
using System.Linq;

namespace five
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Rotate2(arr, 3);

            System.Console.WriteLine(arr);

            Console.ReadKey();
        }


        static int[] Rotate(int[] arr, int k)
        {
            var actureMove = k % arr.Length;

            var isSelfRound = arr.Length % actureMove == 0;

            int temp;
            if (isSelfRound)
            {
                for (int i = 0; i < k; i++)
                {
                    temp = arr[i];
                    for (int j = i; j < arr.Length; j += k)
                    {
                        var replaceIndex = j + k;

                        if (replaceIndex < arr.Length)
                        {
                            temp = arr[replaceIndex];
                        }
                        arr[replaceIndex] = arr[j];
                    }
                }

            }
            else
            {

            }

            return arr;
        }

        static void Rotate2(int[]  nums, int k)
        {
            var actureMove = nums.Length - (k % nums.Length);

            var arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[(actureMove + i) % nums.Length];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];
            }
        }
    }
}
