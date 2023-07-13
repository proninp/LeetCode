using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 226. Invert Binary Tree
     * Given the root of a binary tree, invert the tree, and return its root.
     */
    internal class _226InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            (root.left, root.right) = (root.right, root.left);
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
    }
}
