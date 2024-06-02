use RecipeDB
go

Create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0, 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0), @All = isnull(@All,0)

	select c.CookbookId, C.StaffId, c.CookbookName, Author = concat(s.FirstName, ' ', s.LastName), "NumRecipes" = count(cr.RecipeId), c.Price, c.CookbookActive, "CookbookSkillLevel" = c.CookbookSkillLevelDesc, c.DateDrafted
	from Cookbook c
	join Staff s 
	on c.StaffId = s.Staffid
	left join CookbookRecipe cr
	on cr.CookbookId = c.CookbookId
	where c.CookbookId = @CookbookId
	or @All = 1
	group by c.CookbookId, C.StaffId, c.CookbookName, concat(s.FirstName, ' ', s.LastName), c.price, c.CookbookActive, c.DateDrafted, c.CookbookSkillLevelDesc
	union select 0, 0, '', '', 0, 0, 0, '',null
	where @IncludeBlank = 1
	order by c.CookbookName

	return @return
end
go

--exec CookbookGet @All = 1