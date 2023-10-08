using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 821. Shortest Distance to a Character
     * Given a string s and a character c that occurs in s,
     * return an array of integers answer where answer.length == s.length and
     * answer[i] is the distance from index i to the closest occurrence of character c in s.
     * The distance between two indices i and j is abs(i - j), where abs is the absolute value function.
     */
    public class _821ShortestDistanceToACharacter
    {
        public static int[] ShortestToChar(string s, char c)
        {
            var len = s.Length;
            var ans = new int[len];
            var positions = new List<int>();
            for (int i = 0; i < len; i++)
                if (s[i] == c)
                    positions.Add(i);
            for (int i = 0, l = 0, r = 0; i < len; i++)
            {
                if (i < positions[l])
                    ans[i] = positions[l] - i;
                else
                {
                    if ((i > positions[r]) && r < positions.Count - 1)
                        l = r++;
                    ans[i] = Math.Min(Math.Abs(i - positions[l]), Math.Abs(i - positions[r]));
                }
            }
            return ans;
        }
    }
}
