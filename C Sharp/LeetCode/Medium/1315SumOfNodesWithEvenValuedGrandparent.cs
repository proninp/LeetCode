using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 1315. Sum of Nodes with Even-Valued Grandparent
     * Given the root of a binary tree, return the sum of values of nodes with an even-valued grandparent.
     * If there are no nodes with an even-valued grandparent, return 0.
     * A grandparent of a node is the parent of its parent if it exists.
     */
    internal class _1315SumOfNodesWithEvenValuedGrandparent
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            int sum = 0;
            Traverse(root, null, null);
            void Traverse(TreeNode node, TreeNode parent, TreeNode grandparent)
            {
                sum += (grandparent != null && grandparent.val % 2 == 0 ? node.val : 0);
                if (node.left != null)
                    Traverse(node.left, node, parent);
                if (node.right != null)
                    Traverse(node.right, node, parent);
            }
            return sum;
        }
    }
}
