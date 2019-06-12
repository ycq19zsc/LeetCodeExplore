using System;
using System.Collections.Generic;
using System.Linq;

namespace MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class MinStack
    {
        private List<int> _arr;

        /** initialize your data structure here. */
        public MinStack()
        {
            _arr = new List<int>();
        }

        public void Push(int x)
        {
            _arr.Add(x);
        }

        public void Pop()
        {
            _arr.RemoveAt(_arr.Count - 1);
        }

        public int Top()
        {
            if (_arr.Count == 0)
            {
                return 0;
            }
            return _arr[_arr.Count - 1];
        }

        public int GetMin()
        {
            return _arr.Min();
        }
    }
}
