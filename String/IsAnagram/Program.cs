using System;
using System.Collections.Generic;

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            if (s.Length == 0)
            {
                return true;
            }

            var dictS = new Dictionary<char, int>();
            var dictT = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictS.ContainsKey(s[i]))
                {
                    dictS[s[i]]++;
                }
                else
                {
                    dictS[s[i]] = 1;
                }

                if (dictT.ContainsKey(t[i]))
                {
                    dictT[t[i]]++;
                }
                else
                {
                    dictT[t[i]] = 1;
                }
            }

            foreach (var item in dictS)
            {
                if (dictT.ContainsKey(item.Key))
                {
                    if (dictT[item.Key] == item.Value)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
