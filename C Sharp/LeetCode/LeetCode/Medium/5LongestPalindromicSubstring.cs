﻿namespace LeetCode.Medium
{
    /*
     * 5. Longest Palindromic Substring
     * Given a string s, return the longest palindromic substring in s.
     */
    public class _5LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            int maxLength = 0, startIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int start = i, end = i;
                while (end < s.Length - 1 && s[start] == s[end + 1])
                    end++;

                while (end < s.Length - 1 && start > 0 && s[start - 1] == s[end + 1])
                {
                    start--;
                    end++;
                }
                if (maxLength < end - start + 1)
                {
                    maxLength = end - start + 1;
                    startIndex = start;
                }
            }
            return s.Substring(startIndex, maxLength);
        }
    }
}
