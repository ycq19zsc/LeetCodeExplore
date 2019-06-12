using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(FirstBadVersion(2126753390));
        }

        static bool IsBadVersion(int version)
        {
            if (version >= 1702766719)
            {
                return true;
            }
            return false;
        }

        static int FirstBadVersion(int n)
        {
            return Helper(1, n);
        }

        static int Helper(int startIndex, int endIndex)
        {
            if(startIndex == endIndex) return startIndex;


            var half = startIndex + (endIndex - startIndex) / 2;

            if (IsBadVersion(half))
            {
                return Helper(startIndex, half);
            }

            return Helper(half+1, endIndex);
        }
    }
}
