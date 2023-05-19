using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _118_pascals_triangle
    {
        /*
         * 118. Pascal's Triangle
         * Given an integer numRows, return the first numRows of Pascal's triangle.
         * In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
         * Example 1:
         * Input: numRows = 5
         * Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
         * Example 2:
         * Input: numRows = 1
         * Output: [[1]]
         */
        public static IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> ans = new List<IList<int>>(numRows);
            ans.Add(new List<int>(1) { 1 });
            for (int i = 1; i < numRows; i++)
            {
                List<int> current = new List<int>(i + 1) { 1 };
                for (int j = 1; j < i; j++)
                    current.Add(ans[i - 1][j] + ans[i - 1][j - 1]);
                current.Add(1);
                ans.Add(current);
            }
            return ans;
        }
    }
}
