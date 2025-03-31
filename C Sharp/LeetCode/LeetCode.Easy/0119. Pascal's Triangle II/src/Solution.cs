using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy._0119._Pascal_s_Triangle_II.src;

public sealed class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        var triangle = new int[rowIndex + 1][];
        for (int i = 0; i < triangle.Length; i++)
        {
            triangle[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    triangle[i][j] = 1;
                }
                else
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
        }
        return triangle[rowIndex];
    }
}

