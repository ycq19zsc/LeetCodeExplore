using System;
using BaseTreeNode;

namespace IsSymmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            return IsSymmetricHelper(root.left,root.right);

        }

        static bool IsSymmetricHelper(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null)
            {
                return false;
            }

            if (left.val != right.val)
            {
                return false;
            }

            return IsSymmetricHelper(left.right, right.left) && IsSymmetricHelper(left.left, right.right);
        }
    }
}
