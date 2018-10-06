using System;
using System.Collections.Generic;
using BaseNode;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var head = new ListNode<int>(2);
            head.next = new ListNode<int>(1);

            System.Console.WriteLine(IsPalindrome(head));
        }

        static bool IsPalindrome(ListNode<int> head)
        {
            if (head.next == null)
            {
                return true;
            }

            var stack = new Stack<int>();
            var cuurent = head;

            while (cuurent != null)
            {
                stack.Push(cuurent.val);
                cuurent = cuurent.next;
            }
            var count = stack.Count;

            var reverseHead = new ListNode<int>(0);
            cuurent = reverseHead;
            while (stack.Count != 0)
            {
                cuurent.next = new ListNode<int>(stack.Pop());
                cuurent = cuurent.next;
            }

            reverseHead = reverseHead.next;

            for (int i = 0; i < count / 2; i++)
            {
                if (head.val != reverseHead.val)
                {
                    return false;
                }
                head = head.next;
                reverseHead = reverseHead.next;
            }

            return true;
        }
    }
}
