use RecipeDB
go 

create or alter procedure dbo.AutoCreateCookbook(
    @CookbookId int = 0 output,
	@StaffId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @StaffId = isnull(@StaffId,0)

	insert Cookbook(StaffId, CookbookName, Price, DateDrafted, CookbookActive)
	select s.StaffId, concat('Recipes by ', s.FirstName, ' ', s.LastName), count(r.RecipeId)*1.33, getdate(), 1
	from Staff s
	join Recipe r
	on r.StaffId = s.StaffId
	where r.StaffId = @StaffId
	group by s.StaffId, concat('Recipes by ', s.FirstName, ' ', s.LastName)

	select @CookbookId = scope_identity()

	insert CookbookRecipe(CookbookId, RecipeId, Sequence)
	select @CookbookId , r.RecipeId, row_number() over(order by r.RecipeName)
	from Recipe r
	where r.StaffId = @StaffId
	order by r.RecipeName


	return @return
end
go



--select * from Cookbook where staffId = 3
--select * from CookbookRecipe


--select * from Staff