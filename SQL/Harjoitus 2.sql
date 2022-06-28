-- Harjoitus 2.a
SELECT COUNT(CustomerID) AS 'Lukum‰‰r‰'
FROM Customers

-- Harjoitus 2.b
SELECT SUM(UnitPrice * UnitsInStock)
FROM Products

-- Harjoitus 2.c
SELECT SUM((1-Discount)* UnitPrice * Quantity)
FROM [Order Details]
WHERE ProductID IN (14, 74)
-- WHERE ProductID = 14 OR ProductID = 74
