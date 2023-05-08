exec RecipeGet

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'd'

exec RecipeGet @All = 1