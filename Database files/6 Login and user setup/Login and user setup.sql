--replace //loginname// and //password// with secret values from vault
--IMPORTANT create login in master
create login //losinname// with password = '//password//'

--create user in RecipeDB 
create user cpu_staff_user from login //loginname//

alter role db_datareader add member cpu_staff_user 
alter role db_datawriter add member cpu_staff_user 