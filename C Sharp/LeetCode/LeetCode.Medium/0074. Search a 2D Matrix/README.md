# [74. Search a 2D Matrix](https://leetcode.com/problems/search-a-2d-matrix/)

You are given an `m x n` integer matrix `matrix` with the following two properties:

* Each row is sorted in non-decreasing order.
* The first integer of each row is greater than the last integer of the previous row.

Given an integer `target`, return `true` _if_ `target` _is in_ `matrix` _or_ `false` _otherwise_.

You must write a solution in `O(log(m * n))` time complexity.

**Example 1:**

![example1.png](res/ex1.png)

**Input:** `matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3`
**Output:** `true`


**Example 2:**

![example2.png](res/ex2.png)

**Input:** `matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13`
**Output:** `false`


**Constraints:**

* `m == matrix.length`
* `n == matrix[i].length`
* `1 <= m, n <= 100`
* `-10^4 <= matrix[i][j], target <= 10^4`