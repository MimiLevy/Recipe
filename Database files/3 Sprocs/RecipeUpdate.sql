use RecipeDB
go

create or alter procedure dbo.RecipeUpdate(
	@RecipeId int output,
	@StaffId int = 0,
	@CuisineTypeId int = 0,
	@RecipeName varchar(50) = '',
	@Calories int = 0,
	@DateDrafted datetime = null output,
	@DatePublished datetime = null output,
	@DateArchived datetime = null output,
	@UpdateOnlyStatus bit = 0,
	@Messge varchar(100) = '' output
)
as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), @StaffId = isnull(@StaffId ,0), @CuisineTypeId = isnull(@CuisineTypeId,0)

	if(@UpdateOnlyStatus = 1)
	begin
		update Recipe
		set 
		DateDrafted = @DateDrafted,
		DatePublished = @DatePublished,
		DateArchived = @DateArchived
		where RecipeId = @RecipeId
	goto finished
	end

	else if(@RecipeId = 0)
	begin
		

		insert Recipe(StaffId, CuisineTypeId, RecipeName, Calories, DateDrafted)
		values (@StaffId, @CuisineTypeId, @RecipeName, @Calories, getdate())

		select @RecipeId = scope_identity()
	end

	else
	begin	
		update Recipe 
		set 
		StaffId = @StaffId, 
		CuisineTypeId = @CuisineTypeId, 
		RecipeName = @RecipeName, 
		Calories = @Calories, 
		DateDrafted = @DateDrafted
		where RecipeId = @RecipeId
	end

	finished:
	return @return
end
go


