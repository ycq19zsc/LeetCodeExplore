using System;
using System.Collections.Generic;

namespace Intersect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var result = new List<int>();

            foreach (var item in nums1)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            foreach (var item in nums2)
            {
                if (dict.ContainsKey(item))
                {
                    if (dict[item]<1)
                    {
                        dict.Remove(item);
                    }else{
                        dict[item]--;
                        result.Add(item);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
