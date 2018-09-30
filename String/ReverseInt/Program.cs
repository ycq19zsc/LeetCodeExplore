using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] values = { 0, 0x111, 0xfffff, 0x8888, 0x22000022 };
            foreach (int v in values)
            {
                Console.WriteLine("~0x{0:x8} = 0x{1:x8}  origin = {0} after = {1}", v, ~v);
            }
        }
        public int Reverse(int x)
        {
            return MyAtoi(x.ToString());
        }

        public int MyAtoi(string str)
        {
            var startIndex = 0;
            var isNegative = false;
            if (str[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            var charArr = new List<char>();

            for (int i = str.Length - 1; i >= startIndex; i--)
            {
                charArr.Add(str[i]);
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
                return 0;
            }
        }

        public int MyAtoi2(string str)
        {
            var startIndex = 0;
            var isNegative = false;
            if (str[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            // var charArr = new List<char>();

            // for (int i = str.Length - 1; i >= startIndex; i--)
            // {
            //     charArr.Add(str[i]);
            // }

            // var numberStr = new String(charArr.ToArray());

            var numberStr = new string(str.Substring(startIndex).Reverse().ToArray());

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
                return 0;
            }
        }

        public int Reverse3(int x)
        {
            int b = 0, i = 0;
            int abs = 0;
            double count = 0, amount = 0;
            if (x < 0)
            {
                abs = (~(int)x) + 1;
                for (int a = abs; a > 0; a /= 10)
                {
                    i++;
                }
                for (int a = abs; a > 0; a /= 10)
                {
                    b = a % 10;
                    count = b * Math.Pow(10, --i);
                    amount += count;
                }
                if (amount >= Math.Pow(2, 31))
                {
                    return 0;
                }
                else
                {
                    return (~(int)amount) + 1;
                }

            }
            else
            {
                for (int a = x; a > 0; a /= 10)
                {
                    i++;
                }
                for (int a = x; a > 0; a /= 10)
                {
                    b = a % 10;
                    count = b * Math.Pow(10, --i);
                    amount += count;
                }

                if ((int)amount == -2147483648)
                {
                    return (0);
                }
                else
                {
                    return ((int)amount);
                }


            }
        }
    }
}
