using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
     * Given two binary trees original and cloned and given a reference to a node target in the original tree.
     * The cloned tree is a copy of the original tree.
     * Return a reference to the same node in the cloned tree.
     * Note that you are not allowed to change any of the two trees or the target node and the answer must be a reference to a node in the cloned tree.
     */
    internal class _1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(cloned);
            while (queue != null)
            {
                var node = queue.Dequeue();
                if (node.val == target.val)
                    return node;
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }
            return cloned;
        }
    }
}
