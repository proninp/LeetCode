using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 724. Find Pivot Index
     * Given an array of integers nums, calculate the pivot index of this array.
     * The pivot index is the index where the sum of all the numbers strictly to the left of the index
     * is equal to the sum of all the numbers strictly to the index's right.
     * If the index is on the left edge of the array, then the left sum is 0
     * because there are no elements to the left. This also applies to the right edge of the array.
     * Return the leftmost pivot index. If no such index exists, return -1.
     */
    internal class _724FindPivotIndex
    {
        public int PivotIndex(int[] nums)
        {
            int rSum = nums.Sum();
            int lSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rSum -= nums[i];
                if (lSum == rSum)
                    return i;
                lSum += nums[i];
            }
            return -1;
        }
    }
}
