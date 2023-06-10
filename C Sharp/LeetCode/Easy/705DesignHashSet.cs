using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 705. Design HashSet
     * Design a HashSet without using any built-in hash table libraries.
     * Implement MyHashSet class:
     * void add(key) Inserts the value key into the HashSet.
     * bool contains(key) Returns whether the value key exists in the HashSet or not.
     * void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
     * 
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */

    internal class _705DesignHashSet
    {

    }
    public class MyHashSet
    {
        int len = 1_000_001;
        bool[] map;

        public MyHashSet()
        {
            map = new bool[len];
        }

        public void Add(int key)
        {
            map[key] = true;
        }

        public void Remove(int key)
        {
            map[key] = false;
        }

        public bool Contains(int key) => map[key];
    }
}
