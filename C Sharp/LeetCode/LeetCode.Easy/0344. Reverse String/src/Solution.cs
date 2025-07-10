﻿namespace LeetCode.Easy._0344._Reverse_String.src;

public class Solution
{
    public void ReverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}