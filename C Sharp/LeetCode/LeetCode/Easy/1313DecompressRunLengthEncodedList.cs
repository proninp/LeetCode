namespace LeetCode.Easy
{
    /*
     * 1313. Decompress Run-Length Encoded List
     * We are given a list nums of integers representing a list compressed with run-length encoding.
     * Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0).
     * For each such pair, there are freq elements with value val concatenated in a sublist.
     * Concatenate all the sublists from left to right to generate the decompressed list.
     * Return the decompressed list.
     */
    public class _1313DecompressRunLengthEncodedList
    {
        public int[] DecompressRLElist(int[] nums)
        {
            int len = 0;
            for (int i = 0; i < nums.Length; i += 2)
                len += nums[i];
            var output = new int[len];
            int j = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                while (nums[i]-- > 0)
                    output[j++] = nums[i + 1];
            }
            return output;
        }
    }
}
