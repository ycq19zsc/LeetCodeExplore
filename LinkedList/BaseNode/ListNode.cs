using System;

namespace BaseNode
{
    public class ListNode<T>
    {
        public T val;
        public ListNode<T> next;
        public ListNode(T val)
        {
            this.val = val;
        }
    }

    public class ListNode:ListNode<int>
    {
        public ListNode(int val):base(val)
        {
            base.val = val;
        }
    }
}
