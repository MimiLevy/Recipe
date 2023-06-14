declare @recipeid  int

select @recipeid = r.recipeid
from Recipe r
--join RecipeIngredient ri
--on ri.RecipeId = r.RecipeId
--join RecipeDirection rd 
--on rd.RecipeId = r.RecipeId
left join mealcourserecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr 
on cr.recipeid = r.recipeid
where mcr.RecipeId is null
and cr.RecipeId is null

select * from Recipe where recipeid = @recipeid

exec RecipeDelete @RecipeId = @recipeid

select * from Recipe where recipeid = @recipeid
