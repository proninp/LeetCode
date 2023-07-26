/*
 * 1341. Movie Rating
 * Table: Movies
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | movie_id      | int     |
 * | title         | varchar |
 * +---------------+---------+
 * movie_id is the primary key for this table.
 * title is the name of the movie.
 * Table: Users
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | user_id       | int     |
 * | name          | varchar |
 * +---------------+---------+
 * user_id is the primary key for this table.
 * Table: MovieRating
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | movie_id      | int     |
 * | user_id       | int     |
 * | rating        | int     |
 * | created_at    | date    |
 * +---------------+---------+
 * (movie_id, user_id) is the primary key for this table.
 * This table contains the rating of a movie by a user in their review.
 * created_at is the user's review date. 
 * Write an SQL query to:
 * Find the name of the user who has rated the greatest number of movies.
 * In case of a tie, return the lexicographically smaller user name.
 * Find the movie name with the highest average rating in February 2020.
 * In case of a tie, return the lexicographically smaller movie name.
 */
SELECT results
FROM (
       SELECT TOP 1 u.name results
              , COUNT(*) cnt
       FROM MovieRating mr
       JOIN Users u ON u.user_id = mr.user_id
       GROUP BY u.name
       ORDER BY cnt DESC, results
) u
UNION ALL
SELECT title
FROM (
       SELECT TOP 1 m.title
              , AVG(rating * 1.0) rate
       FROM MovieRating mr
       JOIN Movies m ON m.movie_id = mr.movie_id
       WHERE YEAR(mr.created_at) = '2020' AND MONTH(mr.created_at) = '02'
       GROUP BY m.title
       ORDER BY rate DESC, m.title
) r