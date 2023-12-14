use RecipeDB
go

create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@All bit = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0), @All = isnull(@All,0)

	select i.IngredientId, i.IngredientName 
	from Ingredient i
	where @IngredientId = i.IngredientId
	or @All = 1

	return @return
end 
go 

--exec IngredientGet @All = 1