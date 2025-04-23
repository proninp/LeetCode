# 584. Find Customer Referee

Table: `Customer`

```
+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| id          | int     |
| name        | varchar |
| referee_id  | int     |
+-------------+---------+
```

In SQL, `id` is the primary key column for this table.
Each row of this table indicates the id of a customer, their name, and the id of the customer who referred them.


Find the names of the customer that are __not referred by__ the customer with `id = 2`.

Return the result table in __any order__.

The result format is in the following example.



__Example 1:__

__Input:__
Customer table:
```
+----+------+------------+
| id | name | referee_id |
+----+------+------------+
| 1  | Will | null       |
| 2  | Jane | null       |
| 3  | Alex | 2          |
| 4  | Bill | null       |
| 5  | Zack | 1          |
| 6  | Mark | 2          |
+----+------+------------+
```

__Output:__
```
+------+
| name |
+------+
| Will |
| Jane |
| Bill |
| Zack |
+------+
```