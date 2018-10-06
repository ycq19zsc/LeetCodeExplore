using System;
using BaseTreeNode;

namespace IsValidBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Demo1
            // var root = new TreeNode(10);
            // root.left = new TreeNode(5);
            // root.right = new TreeNode(15);
            // root.right.left = new TreeNode(6);
            // root.right.right = new TreeNode(20);

            // System.Console.WriteLine(IsValidBST(root));


            #endregion

            #region Demo2

            var root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(5);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(6);

            System.Console.WriteLine(IsValidBST(root));

            #endregion
        }

        #region wrong

        // static bool IsValidBST(TreeNode root)
        // {
        //     if (root == null)
        //     {
        //         return true;
        //     }
        //     if (root.left == null && root.right == null)
        //     {
        //         return true;
        //     }
        //     else if (root.left != null && root.left.val > root.val)
        //     {
        //         return false;

        //     }
        //     else if (root.right != null && root.right.val < root.val)
        //     {
        //         return false;
        //     }

        //     return IsValidBST(root.left) && IsValidBST(root.right);
        // }
        #endregion

        #region Still Wrong

        // private static int rootVal;
        // static bool IsValidBST(TreeNode root)
        // {
        //     if (root == null)
        //     {
        //         return true;
        //     }
        //     rootVal = root.val;

        //     if (root.left == null && root.right == null)
        //     {
        //         return true;
        //     }
        //     else if (root.left != null && root.left.val >= rootVal)
        //     {
        //         return false;
        //     }
        //     else if (root.right != null && root.right.val <= rootVal){
        //         return false;
        //     }

        //     return LeftSide(root.left) && RightSide(root.right);
        // }

        // static bool LeftSide(TreeNode root)
        // {
        //     if (root == null) return true;
        //     if (root.left == null && root.right == null) return true;

        //     if (root.left != null && root.val <= root.left.val)
        //     {
        //         return false;
        //     }
        //     else if (root.right != null)
        //     {
        //         if (root.val >= root.right.val || root.val >= rootVal)
        //         {
        //             return false;
        //         }
        //     }

        //     return LeftSide(root.left) && LeftSide(root.right);
        // }

        // static bool RightSide(TreeNode root)
        // {
        //     if (root == null) return true;
        //     if (root.left == null && root.right == null) return true;

        //     if (root.left != null && (root.val <= root.left.val || root.val <= rootVal))
        //     {
        //         return false;
        //     }
        //     else if (root.right != null && root.val >= root.right.val)
        //     {
        //         return false;
        //     }

        //     return RightSide(root.left) && RightSide(root.right);
        // }

        #endregion

        #region finally...
        private static bool IsTrue;
        static bool IsValidBST(TreeNode root)
        {
            IsTrue = true;
            return IsValidBSTIn(root);
        }

        static bool IsValidBSTIn(TreeNode root, long maxVal = long.MaxValue, long minVal = long.MinValue)
        {
            if (root == null || (root.right == null && root.left == null))
            {
                return true;
            }

            if (root.left != null)
            {

                if (root.left.val <= minVal || root.left.val >= maxVal || root.left.val >= root.val)
                {
                    return false;
                }
                IsTrue = IsTrue && IsValidBSTIn(root.left, root.val, minVal);
            }

            if (root.right != null)
            {
                if (root.right.val <= minVal || root.right.val >= maxVal || root.right.val <= root.val)
                {
                    return false;
                }
                IsTrue = IsTrue && IsValidBSTIn(root.right, maxVal, root.val);
            }

            return IsTrue;
        }
        #endregion


        #region other solutions

        #region Convert to list then compare sequentially 
        // private static List<int> list = new List<int>();
        // static bool IsValidBST(TreeNode root)
        // {
        //     if (root == null)
        //         return true;
        //     Solve(root);
        //     for (int i = 0; i < list.Count - 1; i++)
        //         if (list[i] >= list[i + 1])
        //             return false;
        //     return true;
        // }
        // static void Solve(TreeNode root)
        // {
        //     if (root.left != null)
        //         Solve(root.left);
        //     list.Add(root.val);
        //     if (root.right != null)
        //         Solve(root.right);
        // }
        #endregion

        #endregion
    }
}
