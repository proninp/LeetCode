using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 1302. Deepest Leaves Sum
     * Given the root of a binary tree, return the sum of values of its deepest leaves.
     */
    internal class _1302DeepestLeavesSum
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return root.val;
            int sum = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                sum = 0;
                int n = queue.Count;
                while(n-- > 0)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }
            }
            return sum;
        }
    }
    
}
