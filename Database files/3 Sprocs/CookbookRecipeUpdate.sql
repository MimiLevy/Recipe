use RecipeDB
go

create or alter procedure dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int output,
	@CookbookId int,
	@RecipeId int,
	@Sequence int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0), @RecipeId = isnull(@RecipeId,0)

	if(@CookbookRecipeId = 0)
	begin
		insert CookbookRecipe(CookbookId, RecipeId, Sequence) 
		values (@CookbookId, @RecipeId, @Sequence)

		select @CookbookRecipeId = scope_identity()
	end

	else
	begin
		update CookbookRecipe
		set
			CookbookId = @CookbookId, 
			RecipeId = @RecipeId, 
			Sequence = @Sequence
		where @CookbookRecipeId = cookbookRecipeId
	end

	return @return
end
go