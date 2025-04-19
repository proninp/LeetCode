# 49. Group Anagrams

Given an array of strings `strs`, group the <span style="color: blue" title="An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, using all the original letters exactly once.">anagrams</span> together. You can return the answer in __any order__.



__Example 1:__
```
Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
```

__Example 2:__
```
Input: strs = [""]

Output: [[""]]
```

__Example 3:__
```
Input: strs = ["a"]

Output: [["a"]]
```