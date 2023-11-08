﻿using System.Net;

namespace LeetCode.Easy
{
    /*
     * 1389. Create Target Array in the Given Order
     * Given two arrays of integers nums and index. Your task is to create target array under the following rules:
     * Initially target array is empty.
     * From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
     * Repeat the previous step until there are no elements to read in nums and index.
     * Return the target array.
     * It is guaranteed that the insertion operations will be valid.
     */
    public class _1389CreateTargetArrayInTheGivenOrder
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var list = new List<int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                list.Insert(index[i], nums[i]);
            }
            return list.ToArray();
        }
    }
}
