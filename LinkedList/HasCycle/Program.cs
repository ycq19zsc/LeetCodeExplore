using System;
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
            var start = head.next;
            var current = head.next;
            
            while (current != null){
                if (current == head) return true;
                current = current.next;
            }
            
            return false;
        }
    }
    
}
