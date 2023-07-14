using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 144. Binary Tree Preorder Traversal
     * Given the root of a binary tree, return the preorder traversal of its nodes' values.
     */
    internal class _144BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            Traversal(root, list);
            return list;
        }
        public void Traversal(TreeNode root, List<int> list)
        {
            if (root == null)
                return;
            list.Add(root.val);
            if (root.left != null)
                Traversal(root.left, list);
            if (root.right != null)
                Traversal(root.right, list);
        }
    }
}
