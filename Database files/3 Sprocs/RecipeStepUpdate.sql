use RecipeDB
go

create or alter procedure dbo.RecipeStepUpdate(
	@RecipeStepId int = 0,
	@RecipeId int = 0,
	@StepDesc varchar(500),
	@Sequence int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeStepId = isnull(@RecipeStepId,0), @RecipeId = isnull(@RecipeId,0)

	if @RecipeStepId = 0
		begin
			insert RecipeStep(RecipeId, StepDesc, Sequence)
			values(@RecipeId,  @StepDesc, @Sequence)

			select @RecipeStepId = scope_identity()
		end
	else
		begin	
			update RecipeStep set
			recipeId = @recipeId,
			StepDesc = @StepDesc, 
			Sequence = @Sequence
			where RecipeStepId = @RecipeStepId
		end

	return @return
end
go