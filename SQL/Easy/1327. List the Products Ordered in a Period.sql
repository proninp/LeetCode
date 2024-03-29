/*
 * 1327. List the Products Ordered in a Period
 * Table: Products
 * +------------------+---------+
 * | Column Name      | Type    |
 * +------------------+---------+
 * | product_id       | int     |
 * | product_name     | varchar |
 * | product_category | varchar |
 * +------------------+---------+
 * product_id is the primary key for this table.
 * This table contains data about the company's products.
 
 * Table: Orders
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | product_id    | int     |
 * | order_date    | date    |
 * | unit          | int     |
 * +---------------+---------+
 * There is no primary key for this table. It may have duplicate rows.
 * product_id is a foreign key to the Products table.
 * unit is the number of products ordered in order_date.
 * Write an SQL query to get the names of products that have at least 100 units ordered in February 2020 and their amount.
 * Return result table in any order.
 */
WITH sub AS (SELECT product_id
                  , SUM(unit) unit
          FROM Orders
          WHERE YEAR(order_date) = 2020 AND MONTH(order_date) = 2
          GROUP BY product_id
          HAVING SUM(unit) > 99
)
SELECT p.product_name
       , sub.unit
FROM sub
JOIN Products p ON sub.product_id = p.product_id