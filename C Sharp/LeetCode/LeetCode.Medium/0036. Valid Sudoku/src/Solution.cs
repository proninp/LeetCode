namespace LeetCode.Medium._0036._Valid_Sudoku.src;

public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var set = new HashSet<char>();

        for (var i = 0; i < board.Length; i++)
        {
            set.Clear();
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == '.') continue;
                if (board[i][j] > '9' || board[i][j] < '1')
                    return false;
                if (!set.Add(board[i][j]))
                    return false;

            }
        }

        for (var i = 0; i < board.Length; i++)
        {
            set.Clear();
            for (var j = 0; j < board[i].Length; j++)
            {
                if (board[j][i] == '.') continue;
                if (!set.Add(board[j][i]))
                    return false;
            }
        }

        for (var i = 0; i < board.Length; i += 3)
        {
            for (var j = 0; j < board[i].Length; j += 3)
            {
                set.Clear();
                for (var k = 0; k < 3; k++)
                {
                    for (var l = 0; l < 3; l++)
                    {
                        if (board[k + i][l + j] == '.') continue;
                        if (!set.Add(board[k + i][l + j]))
                            return false;
                    }
                }
            }
        }
        return true;
    }
}