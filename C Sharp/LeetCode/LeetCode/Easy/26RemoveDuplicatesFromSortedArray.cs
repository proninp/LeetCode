using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 26. Remove Duplicates from Sorted Array
     * Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
     * The relative order of the elements should be kept the same.
     * Then return the number of unique elements in nums.
     * Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
     * Change the array nums such that the first k elements of nums contain the
     * unique elements in the order they were present in nums initially.
     * The remaining elements of nums are not important as well as the size of nums.
     * Return k.
     */
    internal class _26RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            int pos = 1;
            for (int i = 1; i < len; i++)
                if (nums[i] != nums[pos - 1])
                    nums[pos++] = nums[i];
            return pos;
        }
    }
}
