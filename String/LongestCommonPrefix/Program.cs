using System;
using System.Linq;
using System.Text;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(LongestCommonPrefix(new string[]{
                "flower","flow","flight"
            }));

            System.Console.WriteLine(LongestCommonPrefix(new string[]{
                "dog","racecar","car"
            }));
        }

        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var minLength = strs.Min(z=>z.Length);
    
            var longestCommonPerfixSb = new StringBuilder();

            for (int i = 0; i < minLength; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        return longestCommonPerfixSb.ToString();
                    }
                }
                longestCommonPerfixSb.Append(strs[0][i]);
            }

            return longestCommonPerfixSb.ToString();
        }
    }
}
