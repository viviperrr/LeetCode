using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Mode_In_BST
{
    class Program
    {
        static int? prev = 0;
        static int count = 1;
        static int max = 0;

        static void Main(string[] args)
        {
            TreeNode node = new TreeNode(1);
            node.right = new TreeNode(2);
            node.right.left = new TreeNode(2);

            int[] result = FindMode(node);
            foreach (int r in result)
            {
                Console.WriteLine(r);
            }
        }

        static int[] FindMode(TreeNode root)
        {
            if (root == null)
            {
                return new int[0];
            }

            List<int> list = new List<int>();
            InorderTraverser(root, list);

            return list.ToArray();
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        static void InorderTraverser(TreeNode node, List<int> list)
        {
            if (node == null)
            {
                return;
            }

            InorderTraverser(node.left, list);

            if (prev != null)
            {
                if (node.val == prev)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
            }

            if (max < count)
            {
                max = count;
                list.Clear();
                list.Add(node.val);
            }
            else if (max == count)
            {
                list.Add(node.val);
            }

            prev = node.val;

            InorderTraverser(node.right, list);
        }
    }
}
