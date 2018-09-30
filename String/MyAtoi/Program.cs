using System;
using System.Collections.Generic;

namespace MyAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(MyAtoi("words and 987"));
            System.Console.WriteLine(MyAtoi("   -42"));
            System.Console.WriteLine(MyAtoi("-912834 72332"));

        }

        static int MyAtoi(string str)
        {
            str = str.TrimStart();
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            if (str[0] != '-' && str[0] != '+' && (str[0] < '0' || str[0] > '9'))
            {
                return 0;
            }

            var startIndex = 0;
            var isNegative = false;
            if (str[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }
            else if (str[0] == '+')
            {
                startIndex = 1;
            }

            var charArr = new List<char>();

            for (int i = startIndex; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    charArr.Add(str[i]);
                }
                else
                {
                    break;
                }
            }

            if (charArr.Count == 0)
            {
                return 0;
            }

            var numberStr = new String(charArr.ToArray());

            int outInt;
            if (int.TryParse(numberStr, out outInt))
            {
                if (isNegative)
                {
                    return -outInt;
                }
                return outInt;
            }
            else
            {
                if (isNegative)
                {
                    return int.MinValue;
                }
                else
                {
                    return int.MaxValue;
                }
            }
        }
    }
}
