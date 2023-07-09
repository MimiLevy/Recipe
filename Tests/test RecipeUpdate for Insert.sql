declare @message varchar(100) = '', @return int, @recipeid int, @staffid int, @cuisinetypeid int

select top 1  @recipeid =  r.RecipeId from Recipe r
select top 1  @staffid =  r.StaffId from Recipe r
select top 1  @cuisinetypeid =  r.CuisineTypeId from Recipe r

exec @return = RecipeUpdate
	@RecipeId  = @recipeid output,
	@StaffId  = @staffid,
	@CuisineTypeId = @cuisinetypeid,
	@RecipeName = 'Babke Cake',
	@Calories  = 100,
	@DateCreated  = '01/01/23',
	@Messge = @message output

select @return, @message, @recipeid
select * from Recipe where RecipeId = @recipeid