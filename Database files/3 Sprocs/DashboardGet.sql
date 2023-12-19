use RecipeDB
go

create or alter procedure dbo.DashboardGet(
	@Message varchar(1000) = '' output
)
as
begin 
	declare @return int = 0

	select "Type" = '   Recipes   ' , Number = count(*) from Recipe r
	union select "Type" = '   Meals   ' , Number = count(*) from Meal m
	union select "Type" = '   Cookbooks   ' , Number = count(*) from Cookbook c
	order by Type desc

	return @return
end
go 

exec DashboardGet
