select *from  Sales.SalesOrderHeader

select SalesOrderID,OrderDate,SalesOrderNumber,CreditCardID,TerritoryID,SalesPersonID
from Sales.SalesOrderHeader
where TaxAmt<1000 and (SalesPersonID = 279 OR TerritoryID = 6); 

select SalesOrderID,OrderDate,SalesOrderNumber,TerritoryID,SalesPersonID
from Sales.SalesOrderHeader
where TaxAmt<1000 and (SalesPersonID =279 or TerritoryID in (6,4))

select *from Production.Product 
--Working With NULL
select Name,ProductNumber,SafetyStockLevel,Style,Color,Size
from Production.Product
Where  Color<> 'Silver' and Size ='M';

SELECT ProductID, Name, Style, Size, Color 
FROM Production.Product 
WHERE Style IS NOT NULL OR Size IS NOT NULL OR Color IS NOT NULL;

--wildCards
select ProductID,Name, SellStartDate,SellEndDate
from Production.Product
Where Name NOt Like '%B%'

select *from [Person].[Person]
select BusinessEntityID,PersonType,MiddleName
from Person.Person 
Where MiddleName Is NUll or MiddleName<> 'A';

--Displaying Above 1000 rs orders and ordered in sept from Sales.SalesOrderHeader
 select *from Sales.SalesOrderHeader
 select SalesOrderID,OrderDate,TotalDue
 from Sales.SalesOrderHeader
 where OrderDate between '2011-09-01' and '2014-09-30' and TotalDue>1000;

 select SalesOrderID,OrderDate,TotalDue
 from Sales.SalesOrderHeader
 Where OrderDate in ('2011-09-01','2011-09-02','2011-09-03') and 
 TotalDue>2000;
 
 --Working with full text scratch
 select *from Production.ProductReview
 select Comments,ProductID
 from Production.ProductReview
 Where contains (Comments,'Socks')

 select Comments,ProductID
 from Production.ProductReview
 where Rating like 5 ;

 select *from Production.Document
 select FileName,Title
 from Production.Document
 where Title like '%F%'