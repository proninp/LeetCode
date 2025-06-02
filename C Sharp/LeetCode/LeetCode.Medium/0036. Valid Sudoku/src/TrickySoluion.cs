namespace LeetCode.Medium._0036._Valid_Sudoku.src;

public class TrickySoluion
{
    public bool IsValidSudoku(char[][] board)
    {
        var len = board.Length;
        var rows = new int[len];
        var cols = new int[len];
        var boxes = new int[len];

        for (var i = 0; i < len; i++)
        {
            for (var j = 0; j < len; j++)
            {
                var ch = board[i][j];
                if (ch is < '1' or > '9') continue;
                
                var boxIndex = i / 3 * 3 + j / 3;
                var value = 1 << (ch - '0');

                if ((value & rows[i]) != 0 ||
                    (value & cols[j]) != 0 ||
                    (value & boxes[boxIndex]) != 0)
                {
                    return false;
                }
                
                rows[i] |= value;
                cols[j] |= value;
                boxes[boxIndex] |= value;
            }
        }
        return true;
    }
}