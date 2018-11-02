using System;

namespace CountPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(CountPrimes(10));
            System.Console.WriteLine(CountPrimes(11));
        }
        static int _startNum = 2;
        static int _count = 0;
        static int CountPrimes(int n)
        {
            var count = 0;
            var startNum = 2;
            if (n > _startNum)
            {
                count = _count;
                startNum = _startNum;
            }
            for (int j = startNum; j < n; j++)
            {
                count++;
                if (j>2 && j % 2 == 0)
                {
                    count--;
                    continue;
                }
                else
                {
                    for (int i = 3; i <= Math.Sqrt(j); i += 2)
                    {
                        if (j % i == 0)
                        {
                            count--;
                            break;
                        }
                    }
                }
            }

            if (n > _startNum)
            {
                _startNum = n;
                _count = count;
            }

            return count;
        }
    }
}
