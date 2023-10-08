using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 128. Longest Consecutive Sequence
     * Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
     * You must write an algorithm that runs in O(n) time.
     * 
     * Example 1:
     * Input: nums = [100,4,200,1,3,2]
     * Output: 4
     * Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
     * 
     * Example 2:
     * Input: nums = [0,3,7,2,5,8,4,6,0,1]
     * Output: 9
     */
    internal class _128LongestConsecutiveSequence
    {
        public int LongestConsecutive(int[] nums)
        {
            var seqlen = 0;
            int currSeqLen;
            int seqEl;
            var set = new HashSet<int>(nums.Length);
            foreach (var e in nums)
                set.Add(e);
            foreach(var e in set)
            {
                if (!set.Contains(e - 1))
                {
                    currSeqLen = 1;
                    seqEl = e + 1;
                    while(set.Contains(seqEl++))
                        currSeqLen++;
                    if (currSeqLen > seqlen)
                        seqlen = currSeqLen;
                }
            }
            return seqlen;
        }
    }
}
