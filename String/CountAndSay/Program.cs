using System;
using System.Collections.Generic;
using System.Text;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(CountAndSay(1));
            System.Console.WriteLine(CountAndSay(2));
            System.Console.WriteLine(CountAndSay(3));
            System.Console.WriteLine(CountAndSay(4));
            System.Console.WriteLine(CountAndSay(5));
        }

        // static string CountAndSay(int n)
        // {
        //     var str = "1";

        //     if (n == 1)
        //     {
        //         return str;
        //     }

        //     for (int i = 1; i < n; i++)
        //     {
        //         var sb = new StringBuilder();
        //         var arr = new List<char>();
        //         for (int j = 0; j < str.Length; j++)
        //         {
        //             if (arr.Count != 0 && arr[0] != str[j])
        //             {
        //                 sb.Append(arr.Count);
        //                 sb.Append(arr[0]);
        //                 arr = new List<char>();
        //             }

        //             arr.Add(str[j]);
        //         }
        //         sb.Append(arr.Count);
        //         sb.Append(arr[0]);
        //         str = sb.ToString();
        //     }

        //     return str;
        // }

        // static string CountAndSay2(int n) {
        //     var str = "1";

        //     if (n == 1)
        //     {
        //         return str;
        //     }

        //     char currentNumberStr = '1';

        //     for (int i = 1; i < n; i++)
        //     {
        //         var sb = new StringBuilder();
        //         var currentNumberCount = 0;
        //         for (int j = 0; j < str.Length; j++)
        //         {
        //             if (currentNumberStr != str[j] && currentNumberCount != 0)
        //             {
        //                 sb.Append(currentNumberCount) ;
        //                 sb.Append(currentNumberStr) ;

        //                 currentNumberCount = 0;
        //             }

        //             currentNumberStr = str[j];
        //             currentNumberCount++;
        //         }
        //         sb.Append(currentNumberCount) ;
        //         sb.Append(currentNumberStr) ;

        //         str = sb.ToString();
        //     }

        //     return str;
        // }

        // static string CountAndSay(int n)
        // {
        //     var str = "1";

        //     if (n == 1)
        //     {
        //         return str;
        //     }


        //     for (int i = 1; i < n; i++)
        //     {
        //         var currentCharIndex = 0;
        //         var sb = new StringBuilder();
        //         var currentNumberCount = 1;
        //         for (int j = 1; j < str.Length; j++)
        //         {
        //             if (str[currentCharIndex] != str[j])
        //             {
        //                 sb.Append(currentNumberCount);
        //                 sb.Append(str[currentCharIndex]);

        //                 currentCharIndex = j;
        //                 currentNumberCount = 1;
        //             }
        //             else
        //             {
        //                 currentNumberCount++;
        //             }

        //         }
        //         sb.Append(currentNumberCount);
        //         sb.Append(str[currentCharIndex]);

        //         str = sb.ToString();
        //     }

        //     return str;
        // }

        static string CountAndSay(int n)
        {
            var str = "1";

            if (n == 1)
            {
                return str;
            }

            return GetSay(str, n - 1);
        }

        static string GetSay(string str, int remainCount)
        {
            if (remainCount == 0)
            {
                return str;
            }
            var sb = new StringBuilder();
            var currentIndex = 0;
            var currentCharCount = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[currentIndex])
                {
                    sb.Append(currentCharCount);
                    sb.Append(str[currentIndex]);

                    currentIndex = i;
                    currentCharCount = 1;
                }
                else
                {
                    currentCharCount++;
                }

            }

            sb.Append(currentCharCount);
            sb.Append(str[currentIndex]);

            str = sb.ToString();

            return GetSay(str, remainCount - 1);
        }

    }
}
