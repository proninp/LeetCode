/*
 * 1211. Queries Quality and Percentage
 * Table: Queries
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | query_name  | varchar |
 * | result      | varchar |
 * | position    | int     |
 * | rating      | int     |
 * +-------------+---------+
 * There is no primary key for this table, it may have duplicate rows.
 * This table contains information collected from some queries on a database.
 * The position column has a value from 1 to 500.
 * The rating column has a value from 1 to 5. Query with rating less than 3 is a poor query.
 * We define query quality as:
 * The average of the ratio between query rating and its position.
 * We also define poor query percentage as:
 * The percentage of all queries with rating less than 3.
 * Write an SQL query to find each query_name, the quality and poor_query_percentage.
 * Both quality and poor_query_percentage should be rounded to 2 decimal places.
 * Return the result table in any order.
 */
SELECT q.query_name
       , ROUND(SUM(q.rating * 1.0 / position) / COUNT(q.query_name), 2) quality
       , ROUND(SUM(IIF(q.rating < 3, 1, 0)) * 1.0 / COUNT(q.query_name) * 100, 2) poor_query_percentage
FROM Queries q
GROUP BY q.query_name