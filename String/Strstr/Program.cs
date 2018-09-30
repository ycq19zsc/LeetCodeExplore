using System;

namespace Strstr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(Strstr("mississippi", "issip"));
        }
        static int Strstr(string haystack, string needle)
        {
            if (needle == string.Empty || haystack == needle)
            {
                return 0;
            }


            if (haystack.Length < needle.Length)
            {
                return -1;
            }

            var outIndex = 0;
            var innerIndex = 0;

            while (true)
            {
                while (outIndex < haystack.Length && haystack[outIndex] != needle[0])
                {
                    outIndex++;
                }

                if (haystack.Length - outIndex < needle.Length)
                {
                    break;
                }

                innerIndex = outIndex + 1;

                for (int i = 1; i < needle.Length + 1; i++)
                {
                    if (i == needle.Length)
                    {
                        return outIndex;
                    }

                    if (haystack[innerIndex] != needle[i])
                    {
                        break;
                    }
                    innerIndex++;
                    continue;
                }

                outIndex++;
            }

            return -1;

        }
    }
}
