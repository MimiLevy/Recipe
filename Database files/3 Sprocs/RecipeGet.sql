use RecipeDB
go

create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@CookbookName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''
)
as
begin
	declare	@return int = 0

	select @RecipeId = isnull(@RecipeId,0), @RecipeName = isnull(@RecipeName,''), @CookbookName = isnull(@CookbookName,''), @All = isnull(@All,0)

	select r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.RecipeStatus, "User" = concat(s.FirstName, ' ', s.LastName), r.Calories, r.Vegan ,r.DateDrafted, r.DatePublished, r.DateArchived, NumIngredients = count(ri.IngredientId), "ListOrder" = 1, r.RecipePicture
	from Recipe r
	join Staff s
	on s.StaffId = r.StaffId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	left join CookbookRecipe cr
	on cr.recipeid = r.recipeid
	left join Cookbook c
	on c.CookbookId = cr.CookBookId 
	where r.RecipeId = @RecipeId
	or(@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	or(@CookbookName <> '' and c.CookbookName like '%' + @CookbookName + '%')
	or @All = 1
	group by r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.RecipeStatus, concat(s.FirstName, ' ', s.LastName), r.Calories, r.Vegan, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipePicture
	union select 0, 0, 0, '', '', '', 0, 0, null, null, null, 0, 0, ''
	where @IncludeBlank = 1
	order by ListOrder, r.RecipeStatus desc

	return @return
end
go



/*
exec RecipeGet

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'd'

exec RecipeGet @All = 1

exec RecipeGet @Cookbookname = 'Good '
*/

