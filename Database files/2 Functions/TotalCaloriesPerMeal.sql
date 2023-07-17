create or alter function dbo.TotalCaloriesPerMeal(@MealId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.Calories)
	from Meal m
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealCourseRecipe mcr
	on mcr.MealCourseId = mc.MealCourseId
	join Recipe r 
	on r.RecipeId = mcr.RecipeId
	where m.MealId = @MealId
	group by m.MealName

	return @value
end
go

select TotalCaloriesPerMeal = dbo.TotalCaloriesPerMeal(MealId), m.*
from Meal m
