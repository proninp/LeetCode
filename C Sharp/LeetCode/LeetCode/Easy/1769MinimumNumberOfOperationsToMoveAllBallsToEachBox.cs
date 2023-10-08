using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1769. Minimum Number of Operations to Move All Balls to Each Box
     * You have n boxes. You are given a binary string boxes of length n,
     * where boxes[i] is '0' if the ith box is empty, and '1' if it contains one ball.
     * In one operation, you can move one ball from a box to an adjacent box.
     * Box i is adjacent to box j if abs(i - j) == 1. Note that after doing so,
     * there may be more than one ball in some boxes.
     * Return an array answer of size n, where answer[i] is the minimum
     * numberof operations needed to move all the balls to the ith box.
     * Each answer[i] is calculated considering the initial state of the boxes.
     */
    internal class _1769MinimumNumberOfOperationsToMoveAllBallsToEachBox
    {
        public int[] MinOperations(string boxes)
        {
            int len = boxes.Length;
            int[] ans = new int[len];
            var balls = new List<int>();
            for (int i = 0; i < len; i++)
            {
                if ((boxes[i] - '0') > 0)
                    balls.Add(i);
            }
            if (balls.Count == 0)
                return ans;
            for (int i = 0; i < len; i++)
                for (int j = 0; j < balls.Count; j++)
                    ans[i] += Math.Abs(i - balls[j]);
            return ans;
        }
    }
}
