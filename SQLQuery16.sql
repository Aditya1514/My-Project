create table dbo.demo(
 sno int not null,
Name varchar(20),
location varchar(20)
 primary Key (sno)
)
--insterting values using transaction
begin transaction
insert into dbo.demo values (
 1,'Aditya','Rajahmundry'
)
insert into dbo.demo values (
 2,'Aditi','Rajahmundry'
)
commit transaction
go
select *from dbo.demo
 
 update dbo.demo set location='Hyderbad' where Name ='Aditi'

 --Adding new col to our existing table
    Alter table dbo.demo
    Add Address varchar(20);
 --inserting data to new col
   update dbo.demo set Address='CTRI' where sno=1;
   update dbo.demo set Address='HI-Tec city' where sno=2;
 --deleting data from table
   delete from dbo.demo where Address='HI-Tec city'; 
 --again adding data
   insert into dbo.demo (sno,Name,location)
   values (2,'keer','BALTIMORE')
   update dbo.demo set Address='Block4' where sno=2;