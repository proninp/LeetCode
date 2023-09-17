using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 125. Valid Palindrome
     * A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
     * and removing all non-alphanumeric characters, it reads the same forward and backward.
     * Alphanumeric characters include letters and numbers.
     * Given a string s, return true if it is a palindrome, or false otherwise.
     */
    public class _125ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                while (l < r && !char.IsLetterOrDigit(s[l]))
                    l++;
                while (r > l && !char.IsLetterOrDigit(s[r]))
                    r--;
                if (char.ToLower(s[l++]) != char.ToLower(s[r--]))
                    return false;
            }
            return true;
        }
    }
}
