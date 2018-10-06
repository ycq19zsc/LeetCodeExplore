using System;
using System.Collections.Generic;
using BaseNode;

namespace HasCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static bool HasCycle(ListNode head) {
            if (head == null || head.next == null) return false;

            var dict = new HashSet<ListNode>();
            while (head!=null)
            {
                if (dict.Contains(head))
                {
                    return true;
                }
                dict.Add(head);

                head = head.next;
            }
            return false;
        }
    }
    
}
