using System;

namespace ClimbStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(ClimbStairs(1));
            System.Console.WriteLine(ClimbStairs(2));
            System.Console.WriteLine(ClimbStairs(3));
            System.Console.WriteLine(ClimbStairs(4));
            System.Console.WriteLine(ClimbStairs(5));
            System.Console.WriteLine(ClimbStairs(6));
            System.Console.WriteLine(ClimbStairs(7));
            System.Console.WriteLine(ClimbStairs(8));

            // Console.WriteLine(Convert.ToString(44, 2));
        }

        #region FirstWay,slow

        // private static int ways;
        // static int ClimbStairs(int n)
        // {
        //     ways = 0;
        //     FindWays(n);
        //     return ways;
        // }

        // static void FindWays(int leftNum)
        // {
        //     if (leftNum < 3)
        //     {
        //         ways++;
        //     }
        //     if (--leftNum > 0)
        //     {
        //         FindWays(leftNum);
        //     }

        //     if (--leftNum > 0)
        //     {
        //         FindWays(leftNum);
        //     }
        // }
        #endregion

        #region SecondWay,slow
        // static int ClimbStairs(int n)
        // {
        //     return Helper(n);
        // }

        // static int Helper(int n)
        // {
        //     if (n == 1) return 1;
        //     if (n == 2) return 2;

        //     return Helper(--n) + Helper(--n);
        // }

        #endregion

        static int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;

            var arr = new int[n];
            arr[0] = 1;
            arr[1] = 2;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
        }

    }
}
