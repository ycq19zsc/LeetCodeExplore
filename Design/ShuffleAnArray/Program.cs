using System;
using System.Collections.Generic;

namespace ShuffleAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new int[]{1,2,3,4,5,6,7,8};
            var s = new Solution(arr);

            var a = s.Shuffle();
            
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }

    }

    public class Solution
    {
        private readonly int[] _default;

        public Solution(int[] nums)
        {
            _default = nums;
        }

        /** Resets the array to its original configuration and return it. */
        public int[] Reset()
        {
            return _default;
        }

        /** Returns a random shuffling of the array. */
        public int[] Shuffle()
        {
            var clo = new List<int>(_default);
            var result = new int[_default.Length];
            for (int i = 0; i < result.Length; i++)
            {
                var random = new Random().Next(clo.Count-1);
                result[i] = clo[random];
                clo.RemoveAt(random);
            }

            return result;
        }
    }
}
