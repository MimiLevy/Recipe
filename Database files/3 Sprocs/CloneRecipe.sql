use RecipeDB
go

create or alter procedure dbo.CloneRecipe(
	@RecipeId int = 0 output,
	@BasedRecipeId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

		select @RecipeId = isnull(@RecipeId,0), @BasedRecipeId = isnull(@BasedRecipeId,0)
		insert Recipe(StaffId, CuisineTypeId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		select r.StaffId, r.CuisineTypeId, concat(r.RecipeName, ' - clone'), r.Calories, getdate(), null, null
		from Recipe r
		where r.RecipeId = @BasedRecipeId

		select @RecipeId = scope_identity()

		insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, Sequence)
		select @RecipeId,  ri.IngredientId, ri.MeasurementTypeId, ri.Amount, ri.Sequence
		from RecipeIngredient ri
		where ri.RecipeId = @BasedRecipeId

		insert RecipeStep(RecipeId, StepDesc, Sequence)
		select @RecipeId, rs.StepDesc, rs.Sequence
		from RecipeStep rs
		where rs.RecipeId = @BasedRecipeId

	return @return
end
go

