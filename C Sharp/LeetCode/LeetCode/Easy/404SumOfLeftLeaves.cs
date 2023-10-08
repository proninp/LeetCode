using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 404. Sum of Left Leaves
     * Given the root of a binary tree, return the sum of all left leaves.
     * A leaf is a node with no children. A left leaf is a leaf that is the left child of another node.
     */
    internal class _404SumOfLeftLeaves
    {
        public int SumOfLeftLeaves(TreeNode root) => SumOfLeftLeaves(root, false);

        public int SumOfLeftLeaves(TreeNode root, bool isLeft)
        {
            if (root == null)
                return 0;
            if (isLeft && root.left == null && root.right == null)
                return root.val;
            return SumOfLeftLeaves(root.left, true) + SumOfLeftLeaves(root.right, false);
        }
    }
}
