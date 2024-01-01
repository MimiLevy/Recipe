use RecipeDB
go

--AF The cookbook list page shoule show cookbooks sorted by cookbook name

Create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0, 
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @All = isnull(@All,0)

	select c.CookbookId, C.StaffId, c.CookbookName, Author = concat(s.FirstName, ' ', s.LastName), "Num Recipes" = count(cr.RecipeId), c.Price, c.CookbookActive, c.DateDrafted
	from Cookbook c
	join Staff s 
	on c.StaffId = s.Staffid
	--Af After a left join, you shouldn't have a regular join, it can mess up the results sometimes.  In this case, you can just join to staff first and then left join to cookbookrecipe
	left join CookbookRecipe cr
	on cr.CookbookId = c.CookbookId
	where c.CookbookId = @CookbookId
	or @All = 1
	group by c.CookbookId, C.StaffId, c.CookbookName, concat(s.FirstName, ' ', s.LastName), c.price, c.CookbookActive, c.DateDrafted
	order by c.CookbookName

	return @return
end
go

