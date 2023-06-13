/*
 * 619. Biggest Single Number
 * Table: MyNumbers
 * +-------------+------+
 * | Column Name | Type |
 * +-------------+------+
 * | num         | int  |
 * +-------------+------+
 * There is no primary key for this table. It may contain duplicates.
 * Each row of this table contains an integer.
 * A single number is a number that appeared only once in the MyNumbers table.
 * Write an SQL query to report the largest single number. If there is no single number, report null.
 */
WITH q AS (
    SELECT num
           , COUNT(num) cnt
    FROM MyNumbers
    GROUP BY num
)
SELECT MAX(num) num
FROM q
WHERE cnt = 1