using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 706. Design HashMap
     * Design a HashMap without using any built-in hash table libraries.
     * Implement the MyHashMap class:
     * MyHashMap() initializes the object with an empty map.
     * void put(int key, int value) inserts a (key, value) pair into the HashMap.
     * If the key already exists in the map, update the corresponding value.
     * int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
     * void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
     * 
     * Your MyHashMap object will be instantiated and called as such:
     * MyHashMap obj = new MyHashMap();
     * obj.Put(key,value);
     * int param_2 = obj.Get(key);
     * obj.Remove(key);
     */
    internal class _706DesignHashMap
    {

    }
    public class MyHashMap2
    {
        int length = 1_000_001;
        int[] map;
        public MyHashMap2()
        {
            map = new int[length];
        }

        public void Put(int key, int value) => map[key] = value == 0 ? -1 : value;

        public int Get(int key)
        {
            if (map[key] == 0) return -1;
            return map[key] == -1 ? 0 : map[key];
        }

        public void Remove(int key) => map[key] = 0;

    }
    public class MyHashMap
    {
        List<(int, int)>[] map;
        public MyHashMap()
        {
            map = Enumerable.Repeat(new List<(int, int)>(), 1001).ToArray();
        }
        public void Put(int key, int value)
        {
            int hash = GetHash(key);
            if (map[hash].Count == 0)
            {
                map[hash].Add((key, value));
                return;
            }
            for (int i = 0; i < map[hash].Count; i++)
            {
                if (map[hash][i].Item1 == key)
                {
                    map[hash][i] = (key, value);
                    return;
                }   
            }
            map[hash].Add((key, value));
        }
        public int Get(int key)
        {
            int hash = GetHash(key);
            if (map[hash].Count == 0) return -1;
            for (int i = 0; i < map[hash].Count; i++)
            {
                if (map[hash][i].Item1 == key)
                    return map[hash][i].Item2;
            }
            return -1;
        }
        public void Remove(int key)
        {
            int hash = GetHash(key);
            if (map[hash].Count == 0) return;
            for (int i = 0; i < map[hash].Count; i++)
            {
                if (map[hash][i].Item1 == key)
                {
                    map[hash].RemoveAt(i);
                    return;
                }
            }
        }
        public int GetHash(int key) => key % map.Length;
    }
}