using System.Collections.Generic;

namespace LeetCode.Easy
{
    /*
     * 118. Pascal's Triangle
     * Given an integer numRows, return the first numRows of Pascal's triangle.
     * In Pascal's triangle, each number is the sum of the two numbers directly above it.
     */
    public class _118PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> output = new List<IList<int>>(numRows);
            if (numRows == 0) return output;
            output.Add(new List<int>() { 1 });
            if (numRows == 1) return output;
            List<int> list;
            for (int i = 1; i < numRows; i++)
            {
                list = new List<int>(i + 1);
                list.Add(1);
                for (int j = 1; j < i; j++)
                    list.Add(output[i - 1][j - 1] + output[i - 1][j]);
                list.Add(1);
                output.Add(list);
            }
            return output;
        }
    }
}
