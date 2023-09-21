namespace LeetCode.Easy
{
    /*
     * 344. Reverse String
     * Write a function that reverses a string. The input string is given as an array of characters s.
     * You must do this by modifying the input array in-place with O(1) extra memory.
     */
    public class _344ReverseString
    {
        public void ReverseString(char[] s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                (s[l], s[r]) = (s[r], s[l]);
                (l, r) = (l + 1, r - 1);
            }

        }
    }
}
