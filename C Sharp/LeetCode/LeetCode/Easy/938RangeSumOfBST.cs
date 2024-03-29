﻿using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 938. Range Sum of BST
     * Given the root node of a binary search tree and two integers low and high,
     * return the sum of values of all nodes with a value in the inclusive range [low, high].
     */
    internal class _938RangeSumOfBST
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
                return 0;
            int sum = root.val >= low && root.val <= high ? root.val : 0;
            if (root.val > low)
                sum += RangeSumBST(root.left, low, high);
            if (root.val < high)
                sum += RangeSumBST(root.right, low, high);
            return sum;
        }
    }
}
