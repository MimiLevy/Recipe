declare @message varchar(100) = '',
		@return int,
		@recipeid int,	
		@staffid int,
		@cuisinetypeid int,
		@recipename varchar(50),
		@calories int,
		@datecreated datetime

select top 1
		@recipeid = r.RecipeId,	
		@staffid = r.StaffId,
		@cuisinetypeid = r.CuisineTypeId,
		@recipename = r.RecipeName,
		@calories = r.calories,
		@datecreated = r.datecreated
from Recipe r


select @RecipeName = reverse(@recipename)

exec @return = RecipeUpdate
	@RecipeId = @recipeid output,
	@StaffId = @staffid,
	@CuisineTypeId = @cuisinetypeid,
	@RecipeName = @recipename,
	@Calories = @calories,
	@DateCreated =@datecreated,
	@Messge = @message output

select @return, @message, @recipeid

select * from Recipe r where R.recipeid = @recipeid