using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1991. Find the Middle Index in Array
     * Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).
     * A middleIndex is an index where
     * nums[0] + nums[1] + ... + nums[middleIndex-1] == nums[middleIndex+1] + nums[middleIndex+2] + ... + nums[nums.length-1].
     * If middleIndex == 0, the left side sum is considered to be 0.
     * Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.
     * Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.
     */
    internal class _1991FindTheMiddleIndexInArray
    {
        public int FindMiddleIndex(int[] nums)
        {
            int len = nums.Length;
            int lSum = 0;
            int rSum = nums.Sum();
            for (int i = 0; i < len; i++)
            {
                rSum -= nums[i];
                if (rSum == lSum) return i;
                lSum += nums[i];
            }
            return -1;
        }
    }
}
