using System;

namespace HammingWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int HammingWeight(uint n) {
            if(n == 0) return 0;
            
            var res = 0;
            
            for (int i = 0; i < 32; i++)
            {
                if((n & 1) == 1) res ++;
                n >>= 1;
            }
            return res;
        }
    }
}
