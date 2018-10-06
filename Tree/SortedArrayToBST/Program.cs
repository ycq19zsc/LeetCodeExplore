using System;
using BaseTreeNode;

namespace SortedArrayToBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // var arr = new int[] { -10, -3, 0, 5, 9 };
            var arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            var node = SortedArrayToBST(arr);
        }

        static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            TreeNode upperNode = new TreeNode(nums[nums.Length / 2]);
            SortedArrayToBSTHelper(ref upperNode, ref nums, 0, nums.Length - 1);

            return upperNode;
        }

        static void SortedArrayToBSTHelper(ref TreeNode upperNode, ref int[] nums, int startIndex, int endIndex)
        {
            var length = endIndex - startIndex + 1;
            var halfIndex = ((startIndex + endIndex) & 1) == 0 ? (startIndex + endIndex) / 2 : (startIndex + endIndex) / 2 + 1;

            if (upperNode == null)
            {
                upperNode = new TreeNode(nums[halfIndex]);
            }

            if (length > 3)
            {
                SortedArrayToBSTHelper(ref upperNode.left, ref nums, startIndex, halfIndex - 1);
                SortedArrayToBSTHelper(ref upperNode.right, ref nums, halfIndex + 1, endIndex);
            }
            else
            {
                if (length == 2)
                {
                    upperNode.left = new TreeNode(nums[startIndex]);
                }
                else if (length == 3)
                {
                    upperNode.left = new TreeNode(nums[startIndex]);
                    upperNode.right = new TreeNode(nums[endIndex]);
                }
            }
        }
    }
}
