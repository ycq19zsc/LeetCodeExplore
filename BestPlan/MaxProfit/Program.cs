using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            #region too slow
            // var arr = new (int, int)[prices.Length];

            // for (int i = 0; i < prices.Length; i++)
            // {
            //     arr[i] = (prices[i], 0);

            //     for (int j = 0; j < arr.Length; j++)
            //     {
            //         var (a, b) = arr[j];
            //         if (prices[i] > a)
            //         {
            //             var n = prices[i] - a;
            //             if (n > b)
            //             {
            //                 arr[j] = (a, n);
            //             }
            //         }
            //     }
            // }

            // return arr.Select(z => z.Item2).Max();
            #endregion

            var list = new List<(int, int)>() { (prices[0], 0) };

            var minPriceNow = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] <= minPriceNow)
                {
                    minPriceNow = prices[i];
                    list.Add((prices[i], 0));
                    continue;
                }

                for (int j = 0; j < list.Count; j++)
                {
                    var (f, s) = list[j];
                    if (f >= prices[i])
                    {
                        continue;
                    }

                    var n = prices[i] - f;

                    if (n > s)
                    {
                        list[j] = (f, n);
                    }
                }
            }


            return list.Select(z => z.Item2).Max();
        }
    }
}
