namespace LeetCode.Easy
{
    /*
     * 680. Valid Palindrome II
     * Given a string s, return true if the s can be palindrome after deleting at most one character from it.
     */
    public class _680ValidPalindromeII
    {
        public bool ValidPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                if (s[l] == s[r])
                {
                    l++;
                    r--;
                }
                else
                    return (IsPalindrom(s, l + 1, r) || IsPalindrom(s, l, r - 1));
            }
            return true;
        }
        public bool IsPalindrom(string s, int l, int r)
        {
            while (l < r)
            {
                if (s[l++] != s[r--])
                    return false;
            }
            return true;
        }
    }
}
