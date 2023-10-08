﻿using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 27. Remove Element
     * Given an integer array nums and an integer val,
     * remove all occurrences of val in nums in-place. The order of the elements may be changed.
     * Then return the number of elements in nums which are not equal to val.
     * Consider the number of elements in nums which are not equal to val be k,
     * to get accepted, you need to do the following things:
     * Change the array nums such that the first k elements of nums contain the elements which are not equal to val.
     * The remaining elements of nums are not important as well as the size of nums.
     * Return k.
     */
    internal class _27RemoveElement
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int p = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    nums[p++] = nums[i];
            }
            return p;
        }
    }
}
