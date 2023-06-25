/*
 * 1164. Product Price at a Given Date
 * Table: Products
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | product_id    | int     |
 * | new_price     | int     |
 * | change_date   | date    |
 * +---------------+---------+
 * (product_id, change_date) is the primary key of this table.
 * Each row of this table indicates that the price of some product was changed to a new price at some date.
 * Write an SQL query to find the prices of all products on 2019-08-16. Assume the price of all products before any change is 10.
 * Return the result table in any order.
 */
WITH cte as (
    SELECT ROW_NUMBER() OVER(PARTITION BY product_id ORDER BY change_date DESC) num
           , product_id
           , new_price
    FROM Products
    WHERE change_date <= '2019-08-16')
SELECT DISTINCT l.product_id
                , ISNULL(r.new_price, 10) price
FROM Products l
LEFT JOIN (SELECT c.product_id
                  , c.new_price
           FROM cte c
           WHERE c.num = 1) r
ON l.product_id = r.product_id