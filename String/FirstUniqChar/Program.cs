using System;
using System.Collections.Generic;

namespace FirstUniqChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(FirstUniqChar("loveleetcode"));
        }

        static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var item = s[i];
                
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
       
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    return s.IndexOf(item.Key);
                }
            }
            return -1;
        }
    }
}
