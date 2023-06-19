declare @recipeid  int

select top 1 @recipeid = r.recipeid
from Recipe r
join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
join RecipeDirection rd 
on rd.RecipeId = r.RecipeId
left join mealcourserecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr 
on cr.recipeid = r.recipeid
where mcr.RecipeId is null
and cr.RecipeId is null
and r.RecipeStatus = 'published'
order by r.RecipeId desc



select * from Recipe where recipeid = @recipeid

declare @return int, @message varchar(100) 
exec @return = RecipeDelete @RecipeId = @recipeid, @Message = @message output

select @return, @message

select * from Recipe where recipeid = @recipeid
