create or alter procedure RecipeDelete(
	@RecipeId int
)
as
begin
	begin try
		begin tran
		delete RecipeIngredient where recipeid = @RecipeId
		delete RecipeDirection where RecipeId = @RecipeId
		delete Recipe where recipeid = @RecipeId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go
