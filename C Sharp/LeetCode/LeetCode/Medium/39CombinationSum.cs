using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /*
     * 39. Combination Sum
     * Given an array of distinct integers candidates and a target integer target,
     * return a list of all unique combinations of candidates where the chosen numbers sum to target.
     * You may return the combinations in any order.
     * The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency
     * of at least one of the chosen numbers is different.
     * The test cases are generated such that the number of unique combinations that sum up
     * to target is less than 150 combinations for the given input.
     */
    public class _39CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var output = new List<IList<int>>();
            var stack = new Stack<int>();
            Dfs(0, 0);
            return output;
            void Dfs(int i, int sum)
            {
                if (sum == target)
                {
                    output.Add(stack.ToList());
                    return;
                }
                while (i < candidates.Length && sum < target)
                {
                    stack.Push(candidates[i]);
                    Dfs(i, sum + candidates[i]);
                    stack.Pop();
                    i++;
                }
            }
        }
    }
}
