use RecipeDB
go

create or alter procedure dbo.CookbookUpdate(
	@CookbookId int output,
	@StaffId int,
	@CookbookName varchar(50),
	@Price decimal,
	@DateDrafted date output,
	@CookbookActive bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @StaffId = isnull(@StaffId,0)
	
	select @CookbookActive =  isnull(nullif(@CookbookActive, ''), 0)

	if @CookbookId = 0
		begin
			insert Cookbook(StaffId, CookbookName, Price, DateDrafted, CookbookActive)
			values (@StaffId, @CookbookName, @Price, getdate(), @CookbookActive)

			select @CookbookId = scope_identity()
		end
	else 
		begin
			update Cookbook 
			set
			StaffId = @StaffId, 
			CookbookName = @CookbookName, 
			Price = @Price, 
			DateDrafted = @DateDrafted, 
			CookbookActive = @CookbookActive
			where CookbookId = @CookbookId
		end 

	return @return
end
go
