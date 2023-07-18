create or alter function dbo.TotalCaloriesPerMeal(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.Calories)
	from MealCourse mc
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join Recipe r 
	on r.RecipeId = mcr.RecipeId
	where mc.MealId = @MealId

	return @value
end
go

select TotalCaloriesPerMeal = dbo.TotalCaloriesPerMeal(MealId), m.*
from Meal m
