use RecipeDB
go

--AF The meal list page should have the meals sorted by meal name

create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = isnull(@MealId,0), @All = isnull(@All,0)

--Af You have a function to get meal calories, you can use it here.  Also it would be more concise to move this out of the cte, and just join to mealcourserecipe in the regular
-- select statement, and get count of dsitinct mealcourserecipe recipe id
	
	select m.MealId,  m.MealName, "User" = concat(s.FirstName, ' ', s.LastName), NumCalories = dbo.TotalCaloriesPerMeal(m.MealId), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId)
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	left join MealCourse mc
	on mc.MealId = m.MealId
	left join MealCourseRecipe mcr 
	on mcr.MealCourseId = mc.MealCourseId
	where m.MealId = @MealId
	or @All = 1
	group by m.MealId, m.MealName, concat(s.FirstName, ' ', s.LastName)
	order by m.MealName

	return @return
end
go

