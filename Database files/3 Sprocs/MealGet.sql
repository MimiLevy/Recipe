use RecipeDB
go

create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = isnull(@MealId,0), @All = isnull(@All,0)

	;
	with x as(
		select mc.MealId, NumCalories = sum(r.Calories), NumRecipes = count(r.RecipeId)
		from MealCourse mc
		left join MealCourseRecipe mcr
		on mcr.MealCourseId = mc.MealCourseId
		left join Recipe r
		on r.RecipeId = mcr.RecipeId
		group by mc.MealId
	)
	select m.MealId,  m.MealName, "User" = concat(s.FirstName, ' ', s.LastName), x.NumCalories, "Num Courses" = count(mc.CourseId), x.NumRecipes
	from Meal m
	left join MealCourse mc
	on mc.MealId = m.MealId
	join Staff s
	on s.StaffId = m.StaffId
	join x
	on x.MealId = m.MealId
	where m.MealId = @MealId
	or @All = 1
	group by m.MealId, m.MealName, concat(s.FirstName, ' ', s.LastName), x.NumCalories, x.NumRecipes

	return @return
end
go

