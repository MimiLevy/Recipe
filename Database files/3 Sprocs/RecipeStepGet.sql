use RecipeDB
go

create or alter procedure dbo.RecipeStepGet(
	@RecipeStepId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0
	
	select @RecipeStepId = isnull(@RecipeStepId,0), @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0)

	select r.RecipeStepId, r.RecipeId, r.StepDesc, r.Sequence
	from RecipeStep r
	where r.RecipeStepId = @RecipeStepId
	or r.RecipeId = @RecipeId
	or @All = 1
	order by r.Sequence

	return @return
end
go

--exec RecipeStepGet @All = 1
