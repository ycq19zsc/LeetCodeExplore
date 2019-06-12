using System;

namespace IsPowerOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(Math.Pow(3,9));
            System.Console.WriteLine(IsPowerOfThree(19684));
        }

        static bool IsPowerOfThree(int n)
        {
            if (n==1) return true;
            var dN = (double)n ;
            var count = 0;
            while (dN > 3 )
            {
                dN/=3;
                n/=3;
                if (dN!=n)
                {
                    return false;
                }
                count++;
            }
            if (dN!=3)
            {
                return false;
            }
            return true;
        }
    }
}
