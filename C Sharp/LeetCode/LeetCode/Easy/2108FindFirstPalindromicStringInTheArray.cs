using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2108. Find First Palindromic String in the Array
     * Given an array of strings words, return the first palindromic string in the array.
     * If there is no such string, return an empty string "".
     * A string is palindromic if it reads the same forward and backward.
     */
    internal class _2108FindFirstPalindromicStringInTheArray
    {
        public string FirstPalindrome(string[] words)
        {
            foreach (var word in words)
            {
                int l = 0;
                int r = word.Length - 1;
                bool isFound = true;
                while (l < r && isFound)
                    isFound = (word[l++] == word[r--]);
                if (isFound)
                    return word;
            }
            return "";
        }
    }
}
