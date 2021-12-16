--min,max
select *from Production.Product
select MIN(ListPrice) AS Minimum, 
 MAX(ListPrice) AS Maximum, 
 AVG(ListPrice) AS Average 
from Production.Product; 

select *from Sales.SalesOrderDetail
select max(SalesOrderID) from Sales.SalesOrderDetail
select Avg(UnitPrice) from Sales.SalesOrderDetail

--adding count and sum
select max(UnitPrice)as maximun,
 min(UnitPrice) as minimum,
 avg(UnitPrice)as Average,
 count(SalesOrderID) as Aditya,
 sum (LineTotal) as Aditya1
 from Sales.SalesOrderDetail