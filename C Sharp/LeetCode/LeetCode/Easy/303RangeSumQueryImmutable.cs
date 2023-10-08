using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 303. Range Sum Query - Immutable
     * Given an integer array nums, handle multiple queries of the following type:
     * Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
     * Implement the NumArray class:
     * NumArray(int[] nums) Initializes the object with the integer array nums.
     * int sumRange(int left, int right) Returns the sum of the elements of nums
     * between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
     */
    internal static class _303RangeSumQueryImmutable
    {
    }
    public class NumArray
    {
        private readonly int[] sums;
        public NumArray(int[] nums)
        {
            int len = nums.Length;
            sums = new int[len];
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += nums[i];
                sums[i] = sum;
            }
        }
        public int SumRange(int left, int right) =>
            (left == 0) ? sums[right] : (sums[right] - sums[left - 1]);
    }
}
