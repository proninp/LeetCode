namespace LeetCode.Medium
{
    /*
     * 1584. Min Cost to Connect All Points
     * 
     * You are given an array points representing integer coordinates of some points on a 2D-plane, where points[i] = [xi, yi].
     * The cost of connecting two points [xi, yi] and [xj, yj] is the manhattan distance between them:
     * |xi - xj| + |yi - yj|, where |val| denotes the absolute value of val.
     * Return the minimum cost to make all points connected. All points are connected if there is exactly one simple path between any two points.
     */
    public class _1584MinCostTtoConnectAllPoints
    {
        public int MinCostConnectPoints(int[][] points)
        {
            var n = points.Length;
            var dictionary = new Dictionary<int, List<Tuple<int, int>>>();

            if (n == 1)
                return 0;

            for (var i = 0; i < n; i++)
                dictionary.Add(i, new List<Tuple<int, int>>());

            for (var i = 0; i < n; i++)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                for (var j = i + 1; j < n; j++)
                {
                    var x2 = points[j][0];
                    var y2 = points[j][1];
                    var dist = Math.Abs(x2 - x1) + Math.Abs(y1 - y2);
                    dictionary[i].Add(new Tuple<int, int>(dist, j));
                    dictionary[j].Add(new Tuple<int, int>(dist, i));
                }
            }
            var visited = new HashSet<int>();
            var minHeap = new PriorityQueue<(int, int), int>();
            minHeap.Enqueue((0, 0), 0);
            int res = 0;
            while (minHeap.Count > 0)
            {
                var (dist, point) = minHeap.Dequeue();
                if (visited.Contains(point))
                    continue;
                res += dist;
                visited.Add(point);
                if (visited.Count == n)
                    break;
                var adj = dictionary[point];
                for (var i = 0; i < adj.Count; i++)
                    if (!visited.Contains(adj[i].Item2))
                        minHeap.Enqueue((adj[i].Item1, adj[i].Item2), adj[i].Item1);
            }
            return res;
        }
    }
}
