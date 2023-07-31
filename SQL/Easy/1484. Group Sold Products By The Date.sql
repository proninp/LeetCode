/*
 * 1484. Group Sold Products By The Date
 * Table Activities:
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | sell_date   | date    |
 * | product     | varchar |
 * +-------------+---------+
 * This table may contain duplicates (In other words, there is no primary key for this table in SQL).
 * Each row of this table contains the product name and the date it was sold in a market.
 * Find for each date the number of different products sold and their names.
 * The sold products names for each date should be sorted lexicographically.
 * Return the result table ordered by sell_date.
 */
SELECT sell_date
       , COUNT(product) num_sold
       , STRING_AGG(product, ',') WITHIN GROUP(ORDER BY product) products
FROM (SELECT DISTINCT sell_date, product
      FROM Activities) a
GROUP BY sell_date