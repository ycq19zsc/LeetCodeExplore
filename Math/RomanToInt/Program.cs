using System;
using System.Collections.Generic;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // System.Console.WriteLine(RomanToInt("III"));
            // System.Console.WriteLine(RomanToInt("IV"));
            // System.Console.WriteLine(RomanToInt("IX"));
            // System.Console.WriteLine(RomanToInt("LVIII"));
            System.Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        static List<A> list = new List<A>(){
            new A{Key='I',Val=1},
            new A{Key='V',Val=5, Son=new A{Key='I',Val=-1}},
            new A{Key='X',Val=10, Son=new A{Key='I',Val=-1}},
            new A{Key='X',Val=10 },
            new A{Key='L',Val=50, Son=new A{Key='X',Val=-10}},
            new A{Key='C',Val=100, Son=new A{Key='X',Val=-10}},
            new A{Key='C',Val=100},
            new A{Key='D',Val=500, Son=new A{Key='C',Val=-100}},
            new A{Key='M',Val=1000, Son=new A{Key='C',Val=-100}},
            new A{Key='M',Val=1000}
        };

        static int RomanToInt(string s)
        {

            var charArr = s.ToCharArray();
            Array.Reverse(charArr);
            // var str = new string(charArr);

            var sum = 0;

            var currentIndex = 0; 

            for (int i = 0; i < list.Count; i++)
            {
                if (currentIndex >= charArr.Length)
                {
                    return sum;
                }

                var indexOf = 0;

                while (currentIndex<charArr.Length && charArr[currentIndex] == list[i].Key)
                {
                    indexOf++;
                    currentIndex++;
                }

                if (indexOf == 0)
                {
                    continue;
                }

                sum += list[i].Val * indexOf;

                if ((currentIndex<charArr.Length && list[i].Son!=null &&  charArr[currentIndex]  == list[i].Son.Key))
                {
                    sum += list[i].Son.Val;
                    currentIndex++;
                }
            }

            return sum;
        }


    }

    class A
    {
        public char Key { get; set; }
        public int Val { get; set; }
        public A Son { get; set; }
    }
}
