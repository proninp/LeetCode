namespace LeetCode.Medium
{
    /*
     * 1689. Partitioning Into Minimum Number Of Deci-Binary Numbers
     * A decimal number is called deci-binary if each of its digits is either 0 or 1 without any leading zeros.
     * For example, 101 and 1100 are deci-binary, while 112 and 3001 are not.
     * Given a string n that represents a positive decimal integer,
     * return the minimum number of positive deci-binary numbers needed so that they sum up to n.
     */
    internal class _1689PartitioningIntoMinimumNumberOfDeciBinaryNumbers
    {
        public int MinPartitions(string n)
        {
            int max = n[0];
            for (int i = 1; i < n.Length; i++)
                if (n[i] > max)
                    max = n[i];
            return max - '0';
        }
    }
}
