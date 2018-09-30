using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[] PlusOne(int[] digits)
        {
            bool addOne = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (addOne)
                {
                    digits[i]++;
                    addOne = false;
                }

                if (digits[i] == 10)
                {
                    addOne = true;
                    digits[i] = 0;
                }
                else
                {
                    break;
                }
            }

            if (addOne)
            {
                var arr = new int[digits.Length + 1];
                arr[0] = 1;
                for (int i = 0; i < digits.Length; i++)
                {
                    arr[i + 1] = digits[i];
                }
                return arr;
            }
            else
            {
                return digits;
            }
        }
    }
}
