using System;

namespace LeetCode.Medium
{
    /*
     * 2038. Remove Colored Pieces if Both Neighbors are the Same Color
     * 
     * There are n pieces arranged in a line, and each piece is colored either by 'A' or by 'B'.
     * You are given a string colors of length n where colors[i] is the color of the ith piece.
     * Alice and Bob are playing a game where they take alternating turns removing pieces from the line. In this game, Alice moves first.
     * Alice is only allowed to remove a piece colored 'A' if both its neighbors are also colored 'A'.
     * She is not allowed to remove pieces that are colored 'B'.
     * Bob is only allowed to remove a piece colored 'B' if both its neighbors are also colored 'B'.
     * He is not allowed to remove pieces that are colored 'A'.
     * Alice and Bob cannot remove pieces from the edge of the line.
     * If a player cannot make a move on their turn, that player loses and the other player wins.
     * Assuming Alice and Bob play optimally, return true if Alice wins, or return false if Bob wins.
     */
    public class _2038RemoveColoredPieces
    {
        public bool WinnerOfGame(string colors)
        {
            int alice = 0, bob = 0;
            for (int i = 1; i < colors.Length - 1; i++)
            {
                if (colors[i] == colors[i + 1] && colors[i] == colors[i - 1])
                    if (colors[i] == 'A')
                        alice++;
                    else
                        bob++;
            }
            return alice > bob;
        }
    }
}
