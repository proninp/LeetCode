using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 119. Pascal's Triangle II
     * Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
     * In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
     */
    internal class _119PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            var list = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                list.Add(1);
                for (int j = i - 1; j > 0; j--)
                    list[j] = list[j] + list[j - 1];
            }
            return list;
        }
    }
}
