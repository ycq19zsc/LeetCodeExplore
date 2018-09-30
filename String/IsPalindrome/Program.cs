using System;
using System.Text.RegularExpressions;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var s = "A man, a plan, a canal: Panama";

            System.Console.WriteLine(IsPalindrome2(s));


        }

        static bool IsPalindrome(string s)
        {
            s = s.ToUpper();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90)))
                {
                    s = s.Remove(i, 1);
                }
            }

            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

        static bool IsPalindrome2(string s)
        {
            s = s.ToUpper();
            var start = 0;
            var end = s.Length - 1;
            while (start < end)
            {
                var startStr = s[start];
                while (start < end && !((startStr >= 'A' && startStr <= 'Z') || (startStr >= '0' && startStr <= '9')))
                {
                    start++;
                    startStr = s[start];
                }

                var endStr = s[end];
                while (start < end && !((endStr >= 'A' && endStr <= 'Z') || (endStr >= '0' && endStr <= '9')))
                {
                    end--;
                    endStr = s[end];
                }

                if (startStr != endStr)
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
