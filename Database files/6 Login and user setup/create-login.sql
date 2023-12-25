--IMPORTANT create login in MASTER
drop login appadmin
create login appadmin with password = 'WOWwow!@#' 


--IMPORTANT switch to RecipeDB
drop user if exists appadmin_user 
create user appadmin_user from login appadmin