use RecipeDB
go

create or alter procedure RecipeDelete(
	@RecipeId int, 
	@Message varchar(100) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)

	if not exists(
		select * 
		from Recipe r 
		Where @RecipeId = r.recipeid  
		and
		(
			r.RecipeStatus  = 'draft' 
			or (r.RecipeStatus = 'archived' and datediff(day, r.DateArchived, getdate()) > =  30)
		)
	) 
	begin
		select @return = 1, @Message = 'Can only delete Recipe that is archived for over 30 days or is currently drafted.'
		goto finished
	end

	begin try
		begin tran
		delete RecipeIngredient where recipeid = @RecipeId
		delete RecipeStep where RecipeId = @RecipeId
		delete CookbookRecipe where RecipeId = @RecipeId
		delete MealCourseRecipe where recipeid = @RecipeId
		delete Recipe where recipeid = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go




