use RecipeDB
go

create or alter procedure dbo.CookbookRecipeGet(
	@CookbookId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0 
	
	select @CookbookId = isnull(@CookbookId,0)

	select cr.CookbookRecipeId,cr.CookbookId, cr.RecipeId, cr.Sequence
	from CookbookRecipe cr
	--AF You don't seem to be using any columns in the recipe table so no need to join to it
	left join Recipe r
	on r.RecipeId = cr.RecipeId
	where cr.CookbookId = @CookbookId
	order by cr.Sequence

	return @return
end
go

