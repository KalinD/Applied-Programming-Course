#Problem 1
SELECT * FROM users ORDER BY id;

#Problem 2
SELECT * FROM repositories_contributors AS rc
WHERE rc.contributor_id = rc.repository_id
ORDER BY rc.contributor_id; 

#Problem 3
SELECT i.id, CONCAT(u.username, ' : ', i.title) AS `issue_assignee` FROM issues AS i JOIN users AS u
ON i.assignee_id = u.id ORDER BY i.id DESC;

#Problem 4
SELECT f.id, f.name, CONCAT(f.size, 'KB') AS `size` FROM files AS f
WHERE NOT EXISTS (SELECT p.parent_id FROM files AS p WHERE p.parent_id = f.id)
ORDER BY f.id;

SELECT f.id, f.name, CONCAT(f.size, 'KB') AS `size` FROM files AS f
WHERE f.id NOT IN (SELECT DISTINCT p.parent_id FROM files AS p WHERE p.parent_id IS NOT NULL)
ORDER BY f.id;

#Problem 5
SELECT r.id, r.name, COUNT(*) AS `issues` FROM repositories AS r JOIN issues AS i ON r.id = i.repository_id
GROUP BY r.id, r.name ORDER BY COUNT(*) DESC LIMIT 5;

#Problem 6
SELECT
	r.id, r.name,
	(SELECT COUNT(*) FROM commits AS c WHERE c.repository_id = r.id) AS `commits`,
	(SELECT COUNT(*) FROM repositories_contributors AS rc WHERE rc.repository_id = r.id) AS `contributors`
FROM repositories AS r ORDER BY contributors DESC, r.id LIMIT 1;

#Problem 7
SELECT
	r.id, r.name,
	COUNT(DISTINCT c.contributor_id) AS `users`
FROM repositories AS r LEFT JOIN commits AS c
ON r.id = c.repository_id
GROUP BY r.id
ORDER BY users DESC, r.id;
