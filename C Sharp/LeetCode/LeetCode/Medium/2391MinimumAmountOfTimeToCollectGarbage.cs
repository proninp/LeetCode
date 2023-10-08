using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 2391. Minimum Amount of Time to Collect Garbage
     * You are given a 0-indexed array of strings garbage where garbage[i] represents the assortment of garbage at the ith house.
     * garbage[i] consists only of the characters 'M', 'P' and 'G' representing one unit of metal, paper and glass garbage respectively.
     * Picking up one unit of any type of garbage takes 1 minute.
     * You are also given a 0-indexed integer array travel where travel[i] is the number of minutes needed to go from house i to house i + 1.
     * There are three garbage trucks in the city, each responsible for picking up one type of garbage.
     * Each garbage truck starts at house 0 and must visit each house in order; however, they do not need to visit every house.
     * Only one garbage truck may be used at any given moment.
     * While one truck is driving or picking up garbage, the other two trucks cannot do anything.
     * Return the minimum number of minutes needed to pick up all the garbage.
     */
    internal class _2391MinimumAmountOfTimeToCollectGarbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int sum = garbage[0].Length;
            var map = new Dictionary<char, bool> { { 'G', false }, { 'P', false }, { 'M', false } };
            int trucksInRoute = 0;
            for (int i = garbage.Length - 1; i > 0; i--)
            {
                sum += garbage[i].Length;
                if (trucksInRoute != map.Count)
                {
                    foreach (var c in garbage[i])
                        map[c] = true;
                    trucksInRoute = map.Values.Where(x => x).Count();
                }
                sum += trucksInRoute * travel[i - 1];
            }
            return sum;
        }
    }
}
