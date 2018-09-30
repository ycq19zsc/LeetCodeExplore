using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(ReverseString("abccc"));
        }
        static string ReverseString(string s) {
            var sb = new StringBuilder();
            for (int i =  s.Length-1; i >=0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
