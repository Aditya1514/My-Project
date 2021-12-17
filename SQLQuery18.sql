--parameters
create function add_five1(@num int)
 Returns int
 as
 begin
 Return(
  @num+5
 )
 end
 select dbo.add_five1(183);
 create function add_five11(@num int)
 Returns int
 as
 begin
 Return(
  @num+50
 )
 end
 select dbo.add_five11(183);

 select*from EntryListZoo
 select*from ZooAnimalList

 --create table valued function
 create function Aditya(@gender varchar(20))
 returns table
 as
 return(
  select *from EntryListZoo where gender=@gender
 );

 select *from dbo.Aditya('Female')
 