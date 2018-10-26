using System;

namespace MaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var nums = new int[] { -2, -1 };

            System.Console.WriteLine(MaxSubArray(nums));
        }

        static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            var min = 0;
            var max = 0;

            var sum = 0;

            foreach (var item in nums)
            {
                sum += item;
                if (item >= 0)
                {
                    if (max < sum)
                    {
                        max = sum;
                    }
                }
                else
                {
                    if (min > sum)
                    {
                        min = sum;
                    }
                }
            }
            if (max==0)
            {
                return min;
            }

            return max - min;
        }

    }
}
