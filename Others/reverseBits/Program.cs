using System;
using System.Collections.Generic;

namespace reverseBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = reverseBits(43261596);
            System.Console.WriteLine(a);
        }

        static uint reverseBits(uint n)
        {
            uint ans = 0;

            for (int i = 0; i < 32; i++)
            {
                ans <<= 1;
                ans += n & 1;
                n = n >> 1;
            }

            return ans;

        }


    }
}
