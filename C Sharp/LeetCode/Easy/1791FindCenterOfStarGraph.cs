using System.Collections.Generic;

namespace LeetCode.Easy
{
    /*
     * 1791. Find Center of Star Graph
     * There is an undirected star graph consisting of n nodes labeled from 1 to n.
     * A star graph is a graph where there is one center node and exactly n - 1 edges
     * that connect the center node with every other node.
     * You are given a 2D integer array edges where each edges[i] = [ui, vi]
     * indicates that there is an edge between the nodes ui and vi. Return the center of the given star graph.
     */
    public class _1791FindCenterOfStarGraph
    {
        public int FindCenter(int[][] edges)
        {
            var set = new HashSet<int>(4);
            foreach (var link in edges)
            {
                foreach (var el in link)
                {
                    if (set.Contains(el))
                        return el;
                    set.Add(el);
                }
            }
            return -1;
        }
    }
}
