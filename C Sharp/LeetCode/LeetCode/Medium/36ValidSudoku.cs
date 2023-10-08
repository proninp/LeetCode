using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 36. Valid Sudoku
     * Determine if a 9 x 9 Sudoku board is valid.
     * Only the filled cells need to be validated according to the following rules:
     * Each row must contain the digits 1-9 without repetition.
     * Each column must contain the digits 1-9 without repetition.
     * Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
     * Note:
     * A Sudoku board (partially filled) could be valid but is not necessarily solvable.
     * Only the filled cells need to be validated according to the mentioned rules.
     */
    public class _36ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            int len = board.Length;
            HashSet<char> rowSet;
            int bCol = 0;
            var colSets = new HashSet<char>[len];
            for (int i = 0; i < len; i++)
                colSets[i] = new HashSet<char>();
            var boxes = new HashSet<char>[3];
            for (int row = 0; row < len; row++)
            {
                rowSet = new HashSet<char>();
                for (int col = 0; col < len; col++)
                {
                    bCol = col / 3;
                    if (col % 3 == 0 && row % 3 == 0)
                        boxes[bCol] = new HashSet<char>();
                    var el = board[row][col];
                    if (el == '.')
                        continue;
                    if (!rowSet.Add(el))
                        return false;
                    if (!colSets[col].Add(el))
                        return false;
                    if (!boxes[bCol].Add(el))
                        return false;
                }
            }
            return true;
        }
    }
}
