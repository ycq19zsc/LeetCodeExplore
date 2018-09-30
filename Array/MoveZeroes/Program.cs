using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                var arr = new int[random.Next(100)];

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = random.Next(100);
                }

                MoveZeroes(arr);

                System.Console.Write("[");
                foreach (var item in arr)
                {
                    System.Console.Write(item + ",");
                }
                System.Console.Write("]");

                System.Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void MoveZeroes(int[] nums)
        {
            var endIndex = nums.Length;
            for (int i = 0; i < endIndex; i++)
            {
                while (nums[i] == 0 && i < endIndex - 1)
                {
                    for (int j = i; j < endIndex - 1; j++)
                    {
                        (nums[j], nums[j + 1]) = (nums[j + 1], nums[j]);
                    }
                    endIndex--;
                }
            }
        }
    }
}
