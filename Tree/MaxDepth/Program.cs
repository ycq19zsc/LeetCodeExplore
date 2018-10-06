using System;
using BaseTreeNode;

namespace MaxDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int MaxDepth(TreeNode root)
        {
            return NextDepth(root,0);
        }

        static int NextDepth(TreeNode currentNode, int currentDepth)
        {
            currentDepth++;
            if (currentNode == null)
            {
                return currentDepth;
            }
            
            return Math.Max(NextDepth(currentNode.left, currentDepth), NextDepth(currentNode.right, currentDepth));
        }
        
        // 国内最快算法 2018年10月6日
        // static int MaxDepth(TreeNode root){
        //     // 使用递归寻找深度
        //     if(root == null){
        //         return 0;
        //     }else{
        //         int i = MaxDepth(root.left);
        //         int j = MaxDepth(root.right);
        //         return (i>j) ? i+1:j+1;
        //     }
        // }
    }
}
