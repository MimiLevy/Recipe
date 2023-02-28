--AS Amazing job!! 100%
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.
use HearthyHearthDB 
go 

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete ri
from Recipe r 
join staff s 
on r.StaffId = s.StaffId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where s.UserName = '1234J.L.'

delete rd
from Recipe r 
join staff s 
on r.StaffId = s.StaffId
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
where s.UserName = '1234J.L.'

delete mcr
from Recipe r 
join staff s 
on r.StaffId = s.StaffId
join MealCourseRecipe mcr 
on r.RecipeId = mcr.RecipeId
where s.UserName = '1234J.L.'

delete cr
from Recipe r 
join staff s 
on r.StaffId = s.StaffId
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId
where s.UserName = '1234J.L.'

delete r
from Recipe r 
join staff s 
on r.StaffId = s.StaffId
where s.UserName = '1234J.L.'

delete mcr
from staff s 
join Meal m 
on s.StaffId = m.StaffId
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
where s.UserName = '1234J.L.'

delete mc
from staff s 
join Meal m 
on s.StaffId = m.StaffId
join MealCourse mc 
on m.MealId = mc.MealId
where s.UserName = '1234J.L.'

delete m
from staff s 
join Meal m 
on s.StaffId = m.StaffId
where s.UserName = '1234J.L.'

delete cr
from staff s 
join Cookbook c 
on s.StaffId = c.StaffId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
where s.UserName = '1234J.L.'

delete c
from staff s 
join Cookbook c 
on s.StaffId = c.StaffId
where s.UserName = '1234J.L.'

delete s
from staff s 
where s.UserName = '1234J.L.'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(StaffId,CuisineTypeId,RecipeName,Calories,DateCreated,DatePublished,DateArchived)
select r.StaffId, r.CuisineTypeId, concat(r.RecipeName, ' - clone'), r.Calories, '06/22/2022', null, null
from Recipe r  
where r.RecipeName = 'Easy homemade Ice Cream'
 
;
with x as (
	select r.RecipeId 
	from Recipe r 
	where r.RecipeName = 'Easy homemade Ice Cream - clone'
)
insert RecipeIngredient(RecipeId,IngredientId,MeasurementTypeId,Amount,IngredientSequence)
select x.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.Amount, ri.IngredientSequence
from Recipe r
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
cross join x 
where r.RecipeName = 'Easy homemade Ice Cream'

;
with x as (
	select r.RecipeId 
	from Recipe r 
	where r.RecipeName = 'Easy homemade Ice Cream - clone'
)
insert RecipeDirection(RecipeId,DirectionDesc,DirectionSequence)
select x.RecipeId, rd.DirectionDesc, rd.DirectionSequence
from RecipeDirection rd 
join Recipe r 
on rd.RecipeId = r.RecipeId
cross join x 
where r.RecipeName = 'Easy homemade Ice Cream'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The prices should be the number of recipes times $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
	select Price = 1.33*count(r.RecipeId)
	from Recipe r
)
insert Cookbook(StaffId,CookbookName,Price,CookbookActive)
select top 1 s.StaffId, concat('Recipes by ', s.FirstName, ' ', s.LastName), x.Price, 1
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
cross join x 
where s.UserName = 'M.K.LoveFood'

insert CookbookRecipe(CookbookId,RecipeId,CookbookRecipeSequence)
select c.CookbookId, r.Recipeid, row_number() over (order by r.RecipeName)
from Staff s 
join Cookbook c 
on s.StaffId = c.StaffId 
join Recipe r 
on s.StaffId = r.StaffId
where s.UserName = 'M.K.LoveFood'
and c.CookbookName = 'Recipes by Michael Kors'

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calories for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count of butter went down by 2 per ounce, and 10 for a stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above.
*/
update r
set r.Calories = case when mt.MeasurementTypeDesc = 'Cup' then r.Calories + 76*(ri.Amount)
				 when mt.MeasurementTypeDesc = 'tsp' then r.Calories + 4.5*(ri.Amount)
			     end 
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on ri.IngredientId = i.IngredientId
join MeasurementType mt 
on ri.MeasurementTypeId = mt.MeasurementTypeId
where i.IngredientName = 'sugar'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time all recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
	select AvgHourDiff = avg(datediff(hour,r.DateCreated,r.DatePublished))
	from Recipe r 
)
select s.FirstName, s.LastName, EmailAdress = concat(substring(s.FirstName,1,1),s.LastName,'@heartyhearth.com'), Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour,r.DateCreated,getdate()), ' hours.
That is ', datediff(hour,r.DateCreated,getdate()) - x.AvgHourDiff, ' hours more than the average ',x.AvgHourDiff, ' hours all other recipes took to be published.')
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId 
cross join x 
where r.DatePublished is null and r.DateArchived is null
and datediff(hour,r.DateCreated,getdate()) > x.AvgHourDiff

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average prices is [Y]. You can order all for 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(c.CookbookId), ' books for sale, average prices is ', convert(decimal (6,2),avg(c.Price)), '. You can order all for 25% discount, for a total of ', convert(decimal(6,2), 0.75* avg(c.Price)),
'. Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from Cookbook c   
