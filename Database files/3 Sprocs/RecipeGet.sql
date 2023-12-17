use RecipeDB
go

create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''
)
as
begin
	declare	@return int = 0

--Af You should have isnull for RecipeName
	select @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0)

	select r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.RecipeStatus, "User" = concat(s.FirstName, ' ', s.LastName), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, "Num Ingredients" = count(ri.IngredientId), "ListOrder" = 1
	from Recipe r
	join Staff s
	on s.StaffId = r.StaffId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId
	or(@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	or @All = 1
	group by r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.RecipeStatus, concat(s.FirstName, ' ', s.LastName), r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
	union select 0, 0, 0, '', '', '', 0, null, null, null, 0, 0
	where @IncludeBlank = 1
	order by ListOrder, r.RecipeStatus desc

	return @return
end
go

--exec RecipeGet @All = 1 , @IncludeBlank = 1

/*
exec RecipeGet

declare @RecipeId int
select top 1 @RecipeId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RecipeId

exec RecipeGet @RecipeName = ''
exec RecipeGet @RecipeName = 'd'

exec RecipeGet @All = 1
*/

