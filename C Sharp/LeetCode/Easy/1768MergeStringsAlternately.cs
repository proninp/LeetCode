using System.Text;

namespace LeetCode.Easy
{
    /*
     * 1768. Merge Strings Alternately
     * You are given two strings word1 and word2.
     * Merge the strings by adding letters in alternating order, starting with word1.
     * If a string is longer than the other, append the additional letters onto the end of the merged string.
     * Return the merged string.
     */
    public class _1768MergeStringsAlternately
    {
        public string MergeAlternately(string word1, string word2)
        {
            var len1 = word1.Length;
            var len2 = word2.Length;
            var sb = new StringBuilder(len1 + len2);
            int p1 = 0, p2 = 0;
            while (p1 < len1 && p2 < len2)
            {
                if (p1 < len1) sb.Append(word1[p1++]);
                if (p2 < len2) sb.Append(word2[p2++]);
            }
            if (p1 < len1) sb.Append(word1.Substring(p1));
            if (p2 < len2) sb.Append(word2.Substring(p2));
            return sb.ToString();
        }

    }
}
