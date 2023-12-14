use RecipeDB
go

create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@All bit = 0,
	@RecipeId int = 0,
	@Message varchar(1000) = '' output
)
as
begin
  declare @return int = 0

  select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId,0)
 
  select ri.RecipeIngredientId, ri.RecipeId, ri.Amount, ri.IngredientId, ri.MeasurementTypeId, ri.Sequence
  from RecipeIngredient ri
  where ri.RecipeIngredientId = @RecipeIngredientId
  or ri.RecipeId = @RecipeId
  or @All = 1
  order by ri.Sequence


  return @return
end
go

--exec RecipeIngredientGet @All = 1

