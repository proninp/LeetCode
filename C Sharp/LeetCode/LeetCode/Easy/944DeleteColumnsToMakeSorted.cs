using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 944. Delete Columns to Make Sorted
     * You are given an array of n strings strs, all of the same length.
     * The strings can be arranged such that there is one on each line, making a grid.
     * For example, strs = ["abc", "bce", "cae"] can be arranged as follows:
     * abc
     * bce
     * cae
     * You want to delete the columns that are not sorted lexicographically.
     * In the above example (0-indexed), columns 0 ('a', 'b', 'c') and 2 ('c', 'e', 'e') are sorted,
     * while column 1 ('b', 'c', 'a') is not, so you would delete column 1.
     * Return the number of columns that you will delete.
     */
    internal class _944DeleteColumnsToMakeSorted
    {
        public int MinDeletionSize(string[] strs)
        {
            int cols = strs[0].Length;
            int rows = strs.Length;
            if (rows == 1)
                return 0;
            int ans = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows - 1; row++)
                {
                    if (strs[row][col] > strs[row + 1][col])
                    {
                        ans++;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
