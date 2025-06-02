using System.Text;

namespace LeetCode.Easy._0125._Valid_Palindrome.src;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        for(int left = 0, right = s.Length - 1; left < right;)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
                left++;

            while (left < right && !char.IsLetterOrDigit(s[right]))
                right--;
            
            if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;
            left++;
            right--;
        }
        return true;
    }
}