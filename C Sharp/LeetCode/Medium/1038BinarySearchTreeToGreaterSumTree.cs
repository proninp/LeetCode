using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 1038. Binary Search Tree to Greater Sum Tree
     * Given the root of a Binary Search Tree (BST),
     * convert it to a Greater Tree such that every key of the original
     * BST is changed to the original key plus the sum of all keys greater than the original key in BST.
     * As a reminder, a binary search tree is a tree that satisfies these constraints:
     * The left subtree of a node contains only nodes with keys less than the node's key.
     * The right subtree of a node contains only nodes with keys greater than the node's key.
     * Both the left and right subtrees must also be binary search trees.
     */
    internal class _1038BinarySearchTreeToGreaterSumTree
    {
        public TreeNode BstToGst(TreeNode root)
        {
            var tSum = 0;
            BstToGstRecoursive(root);
            return root;
            void BstToGstRecoursive(TreeNode node)
            {
                if (node == null)
                    return;
                BstToGstRecoursive(node.right);
                tSum += node.val;
                node.val = tSum;
                BstToGstRecoursive(node.left);
            }
        }
    }
}
