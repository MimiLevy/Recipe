use RecipeDB
go

create or alter procedure dbo.RecipeUpdate(
	@RecipeId int output,
	@StaffId int,
	@CuisineTypeId int,
	@RecipeName varchar(50),
	@Calories int,
	@DateCreated datetime,
	@Messge varchar(100) = '' output
)
as 
begin
	declare @return int = 0

	if(@RecipeId = 0)
	begin
		insert Recipe(StaffId, CuisineTypeId, RecipeName, Calories, DateCreated)
		values (@StaffId, @CuisineTypeId, @RecipeName, @Calories, @DateCreated)

		select @RecipeId = scope_identity()
	end

	update Recipe 
	set 
	StaffId = @StaffId, 
	CuisineTypeId = @CuisineTypeId, 
	RecipeName = @RecipeName, 
	Calories = @Calories, 
	DateCreated = @DateCreated
	where RecipeId = @RecipeId

	return @return
end
go
