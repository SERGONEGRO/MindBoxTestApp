SELECT p.Name, c.Name
FROM Products p
LEFT JOIN Categories c
ON p.CategoryId = c.Id
ORDER BY p.Name;