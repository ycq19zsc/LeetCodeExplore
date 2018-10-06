using System;
using System.Collections.Generic;
using System.Linq;
using BaseTreeNode;

namespace LevelOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<List<int>> { };

            if (root == null) return result.ToArray();

            var currentList = new List<TreeNode> { root };

            while (currentList.Count != 0)
            {
                result.Add(currentList.Select(z => z.val).ToList());

                var nextLevelList = new List<TreeNode>();

                foreach (var item in currentList)
                {
                    if (item.left != null)
                    {
                        nextLevelList.Add(item.left);
                    }
                    if (item.right != null)
                    {
                        nextLevelList.Add(item.right);
                    }
                }


                currentList = nextLevelList;
            }

            return result.ToArray();
        }
    }
}
