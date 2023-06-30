using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 942. DI String Match
     * A permutation perm of n + 1 integers of all the integers in the range [0, n] can be represented as a string s of length n where:
     * s[i] == 'I' if perm[i] < perm[i + 1], and
     * s[i] == 'D' if perm[i] > perm[i + 1].
     * Given a string s, reconstruct the permutation perm and return it.
     * If there are multiple valid permutations perm, return any of them.
     */
    internal class _942DIStringMatch
    {
        public int[] DiStringMatch(string s)
        {
            int len = s.Length;
            int maxVal = len;
            int minVal = 0;
            var ans = new int[len + 1];
            for (int i = 0; i < len; i++)
            {
                if (s[i] == 'I')
                    ans[i] = minVal++;
                else
                    ans[i] = maxVal--;
            }
            ans[len] = minVal;
            return ans;
        }
    }
}
