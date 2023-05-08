using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 682. Baseball Game
     * You are keeping the scores for a baseball game with strange rules.
     * At the beginning of the game, you start with an empty record.
     * You are given a list of strings operations,
     * where operations[i] is the ith operation you must apply to the record and is one of the following:
     * An integer x - Record a new score of x.
     * '+' - Record a new score that is the sum of the previous two scores.
     * 'D' - Record a new score that is the double of the previous score.
     * 'C' - Invalidate the previous score, removing it from the record.
     * Return the sum of all the scores on the record after applying all the operations.
     * The test cases are generated such that the answer and all intermediate calculations fit in a 32-bit integer and that all operations are valid.
     */
    internal class _682BaseballGame
    {
        public static int CalPoints(string[] operations)
        {
            int len = operations.Length;
            int j = 0;
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (operations[i] == "C")
                {
                    arr[--j] = 0;
                }
                else if (operations[i] == "D")
                {
                    arr[j] = arr[j - 1] * 2;
                    j++;
                }
                else if (operations[i] == "+")
                {
                    arr[j] = arr[j - 1] + arr[j - 2];
                    j++;
                }
                else
                    arr[j++] = Convert.ToInt32(operations[i]);
            }
            return arr.Sum();
        }
    }
}
