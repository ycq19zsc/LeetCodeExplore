using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new int[] { 3, 2, 4 };
            var result = TwoSum(arr, 6);
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

        }

        static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
            {
                return null;
            }
            if (nums.Length == 2)
            {
                if ((nums[0] + nums[1]) == target)
                {
                    return new int[] { 0, 1 };
                }
                else
                {
                    return null;
                }
            }

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var aim = target - nums[i];
                if (!dict.ContainsKey(aim))
                {
                    dict.Add(aim, i);
                }
                else
                {
                    if (target == (aim + aim))
                    {
                        return new int[] { dict[aim], i };
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    if (dict[nums[i]]!=i)
                    {
                        return new int[] { dict[nums[i]], i };
                    }
                }
            }

            return null;
        }
    }
}
