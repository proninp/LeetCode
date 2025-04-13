# 303. Range Sum Query - Immutable

Given an integer array `nums`, handle multiple queries of the following type:

Calculate the __sum__ of the elements of `nums` between indices `left` and `right` inclusive where `left <= right`.
Implement the `NumArray` class:
* `NumArray(int[] nums)` Initializes the object with the integer array `nums`.
* `int sumRange(int left, int right)` Returns the sum of the elements of `nums` between indices `left` and `right` __inclusive__ (i.e. `nums[left] + nums[left + 1] + ... + nums[right]`).
 

__Example 1:__

__Input__
```
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
```

__Output__
```
[null, 1, -1, -3]
```

__Explanation__
```
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
```