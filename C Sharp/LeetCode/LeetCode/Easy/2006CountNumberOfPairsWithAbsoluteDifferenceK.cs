﻿namespace LeetCode.Easy
{
    /*
     * 2006. Count Number of Pairs With Absolute Difference K
     * 
     * Given an integer array nums and an integer k, return the number of pairs (i, j) where i < j such that |nums[i] - nums[j]| == k.
     * The value of |x| is defined as:
     * x if x >= 0.
     * -x if x < 0.
     * 
     * Constraints:
     * 1 <= nums.length <= 200
     * 1 <= nums[i] <= 100
     * 1 <= k <= 99
     */
    public class _2006CountNumberOfPairsWithAbsoluteDifferenceK
    {
        public int CountKDifference(int[] nums, int k)
        {
            int output = 0;
            for (int i = 0; i < nums.Length - 1; i++)
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[j] - nums[i]) == k)
                        output++;
                }
            return output;
        }
    }
}
