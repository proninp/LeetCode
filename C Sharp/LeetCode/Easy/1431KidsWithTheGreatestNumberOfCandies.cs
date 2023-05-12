using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1431. Kids With the Greatest Number of Candies
     * There are n kids with candies. You are given an integer array candies,
     * where each candies[i] represents the number of candies the ith kid has,
     * and an integer extraCandies, denoting the number of extra candies that you have.
     * Return a boolean array result of length n, where result[i] is true if,
     * after giving the ith kid all the extraCandies,
     * they will have the greatest number of candies among all the kids, or false otherwise.
     * Note that multiple kids can have the greatest number of candies.
     */
    internal class _1431KidsWithTheGreatestNumberOfCandies
    {
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            bool[] ans = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
                ans[i] = candies[i] + extraCandies >= max;
            return ans;
        }
    }
}
