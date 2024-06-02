use RecipeDB
go

create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@WinFormsList bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @MealId = isnull(@MealId,0), @All = isnull(@All,0)

	if(@WinFormsList = 1) 
	select m.MealId, m.StaffId ,m.MealName, "User" = concat(s.FirstName, ' ', s.LastName), Calories = dbo.TotalCaloriesPerMeal(m.MealId), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId)
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	left join MealCourse mc
	on mc.MealId = m.MealId
	left join MealCourseRecipe mcr 
	on mcr.MealCourseId = mc.MealCourseId
	group by m.MealId, m.StaffId, m.MealName,  concat(s.FirstName, ' ', s.LastName) 
	union select 0 ,0 , '', '', 0, 0, 0
	where @IncludeBlank = 1
	order by m.MealName
	
	select m.MealId, m.StaffId ,m.MealName, m.MealDescription, "User" = concat(s.FirstName, ' ', s.LastName), m.DateDrafted, m.MealActive, m.MealPicture, Calories = dbo.TotalCaloriesPerMeal(m.MealId), NumCourses = count(distinct mc.CourseId), NumRecipes = count(distinct mcr.RecipeId)
	from Meal m
	join Staff s
	on s.StaffId = m.StaffId
	left join MealCourse mc
	on mc.MealId = m.MealId
	left join MealCourseRecipe mcr 
	on mcr.MealCourseId = mc.MealCourseId
	where m.MealId = @MealId
	or @All = 1
	group by m.MealId, m.StaffId, m.MealName, m.MealDescription, concat(s.FirstName, ' ', s.LastName), m.DateDrafted, m.MealActive, m.MealPicture
	union select 0 ,0 , '', '', '', null, 0,'',0, 0, 0
	where @IncludeBlank = 1
	order by m.MealName

	return @return	
end
go

--exec MealGet @All = 1

