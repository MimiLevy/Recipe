create or alter function dbo.RecipeInfo(@RecipeId int)
Returns varchar(150)
as
begin
	declare @value varchar(150) = ''
		
		;
		with x as(
			select r.RecipeId, DirectionsPerRecipe = count(rd.RecipeDirectionId)
			from Recipe r
			join RecipeDirection rd
			on r.RecipeId = rd.RecipeId
			where r.RecipeId = @RecipeId
			group by r.RecipeId
		)
		select @value = concat(
			r.RecipeName, ' (', ct.CuisineTypeDesc, ') has ', count(ri.IngredientId), 
			(case when count(ri.IngredientId) = 1 then ' ingredient and ' else ' ingredients and ' end),
			x.DirectionsPerRecipe, ' steps'
		) 
		from Recipe r
		join CuisineType ct 
		on r.CuisineTypeId = ct.CuisineTypeId
		join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		join x
		on x.RecipeId = r.RecipeId
		where r.RecipeId = @RecipeId
		group by r.RecipeName, ct.CuisineTypeDesc, x.DirectionsPerRecipe

	return @value
end
go

select RecipeInfo = dbo.RecipeInfo(r.RecipeId), *
from Recipe r