using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 2265. Count Nodes Equal to Average of Subtree
     * Given the root of a binary tree, return the number of nodes where the value of the node is equal to the average of the values in its subtree.
     * Note:
     * The average of n elements is the sum of the n elements divided by n and rounded down to the nearest integer.
     * A subtree of root is a tree consisting of root and all of its descendants.
     */
    internal class _2265CountNodesEqualToAverageOfSubtree
    {
        public int AverageOfSubtree(TreeNode root)
        {
            int output = 0;
            (int nSum, int nCnt) Traverse(TreeNode node)
            {
                var tNode = (currSum: node.val, currCount: 1);
                if (node.left != null)
                {
                    var left = Traverse(node.left);
                    tNode.currSum += left.nSum;
                    tNode.currCount += left.nCnt;
                }
                if (node.right != null)
                {
                    var right = Traverse(node.right);
                    tNode.currSum += right.nSum;
                    tNode.currCount += right.nCnt;
                }
                if (tNode.currSum / tNode.currCount == node.val)
                    output++;
                return tNode;
            }
            Traverse(root);
            return output;
        }
    }
}
