--procedure
 select *from ZooAnimalList

 create procedure Category @category varchar(20)
 as
  select *from ZooAnimalList
  where Category=@Category
  go
  exec Category @Category='Wild';