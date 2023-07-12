create or alter procedure dbo.RecipeGet
(
	@RecipeId int = 0,
	@RecipeName varchar(50) = '',
	@All bit = 0
)
as
begin
	select r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePicture 
	from Recipe r
	where r.RecipeId = @RecipeId
	or(@RecipeName <> '' and r.RecipeName like '%' + @REcipeName + '%')
	or @All = 1
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
*/