using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1929. Concatenation of Array
     * Given an integer array nums of length n, you want to create an array ans of length 2n
     * where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
     * Specifically, ans is the concatenation of two nums arrays.
     * Return the array ans.
     */
    internal class _1929ConcatenationOfArray
    {
        public static int[] GetConcatenation(int[] nums)
        {
            int len = nums.Length;
            int[] ans = new int[len * 2];
            for (int i = 0; i < len; i++)
            {
                ans[i] = nums[i];
                ans[len + i] = nums[i];
            }
            return ans;
        }
    }
}
