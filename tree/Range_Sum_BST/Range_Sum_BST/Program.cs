using System;

namespace Range_Sum_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            int l = 7;
            int r = 15;

            TreeNode node = new TreeNode(10);
            node.left = new TreeNode(5);
            node.left.left = new TreeNode(3);
            node.left.right = new TreeNode(7);
            node.right = new TreeNode(18);
            node.right.left = new TreeNode(15);

            int sum = solution.RangeSumBST(node, l, r);
            Console.WriteLine(sum);
        }
    }

    public class Solution
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root == null)
            {
                return sum;
            }

            InorderTraverser(root, L, R, ref sum);

            return sum;
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// Space Complexity: O(1)
        /// </summary>
        /// <param name="sum"></param>
        private void InorderTraverser(TreeNode root, int l, int r, ref int sum)
        {
            if (root == null)
            {
                return;
            }

            InorderTraverser(root.left, l, r, ref sum);

            if (root.val >= l && root.val <= r)
            {
                sum += root.val;
            }

            InorderTraverser(root.right, l, r, ref sum);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
