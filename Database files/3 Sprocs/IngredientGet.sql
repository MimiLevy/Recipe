use RecipeDB
go

create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@IngredientName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(1000) = '' output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0), @IngredientName = isnull(@IngredientName,''), @All = isnull(@All,0)

	select i.IngredientId, i.IngredientName 
	from Ingredient i
	where @IngredientId = i.IngredientId
	or(@IngredientName <> '' and i.IngredientName like '%' + @IngredientName + '%')
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1

	return @return	
end 
go 

--exec IngredientGet @IngredientName = 'f'