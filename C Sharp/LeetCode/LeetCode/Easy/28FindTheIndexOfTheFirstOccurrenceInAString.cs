namespace LeetCode.Easy
{
    /*
     * 28. Find the Index of the First Occurrence in a String
     * Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
     */
    public class _28FindTheIndexOfTheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            int p1, p2;
            var needleLen = needle.Length;
            var haystackLen = haystack.Length;
            for (int i = 0; i + needleLen - 1 < haystackLen; i++)
            {
                p1 = 0;
                p2 = i;
                while (p1 < needleLen && p2 < haystackLen && needle[p1] == haystack[p2])
                {
                    p1++;
                    p2++;
                }
                if (p1 == needle.Length)
                    return i;
            }
            return -1;
        }
    }
}
