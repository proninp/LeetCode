using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 108. Convert Sorted Array to Binary Search Tree
     * Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
     */
    internal class _108ConvertSortedArrayToBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return GetNodeRecoursive(0, nums.Length - 1);

            TreeNode GetNodeRecoursive(int l, int r)
            {
                if (l > r)
                    return null;
                int mid = l + (r - l) / 2;
                return new TreeNode(nums[mid], GetNodeRecoursive(l, mid - 1), GetNodeRecoursive(mid + 1, r));
            }
        }
    }
}
