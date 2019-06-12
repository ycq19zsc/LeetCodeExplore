using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var arr = new int[] { 2, 7, 11, 15 };

            var result = TwoSum(arr, 9);

            System.Console.WriteLine(result);
        }

        static int[] TwoSum(int[] numbers, int target)
        {
            var result = new int[] { 0, 0 };
            if (numbers.Length == 0)
            {
                return result;
            }
            var targetDict = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var tNumber = (target - numbers[i]);
                if (!targetDict.ContainsKey(tNumber))
                {
                    targetDict[tNumber] = i + 1;
                }
            }

            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (targetDict.ContainsKey(numbers[i]))
                {
                    index1 = i + 1;
                    index2 = targetDict[numbers[i]];
                    break;
                }
            }

            if (index1 > index2)
            {
                (index1, index2) = (index2, index1);
            }

            if (index1 == index2)
            {
                index2 = index1 + 1;
            }

            result[0] = index1;
            result[1] = index2;

            return result;
        }

        static int[] TwoSum2(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;

            while (true)
            {
                if (numbers[l] + numbers[r] < target)
                {
                    l++;
                }
                if (numbers[l] + numbers[r] > target)
                {
                    r--;
                }

                if (numbers[l] + numbers[r] == target)
                {
                    return new int[] { l + 1, r + 1 };
                }
            }
        }
    }

}
