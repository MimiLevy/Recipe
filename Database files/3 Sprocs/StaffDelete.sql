use RecipeDB
go 

create or alter procedure dbo.StaffDelete(
	@StaffId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	
	select @StaffId = isnull(@StaffId,0)

begin try 
	begin tran
		delete RecipeIngredient 
		from RecipeIngredient ri
		join Recipe r 
		on r.RecipeId = ri.recipeid
		where StaffId = @StaffId

		delete RecipeStep  
		from RecipeStep rs
		join Recipe r 
		on r.RecipeId = rs.recipeid
		where StaffId = @StaffId

		delete MealCourseRecipe 
		from MealCourseRecipe mcr
		join Recipe r 
		on r.RecipeId = mcr.recipeid
		where StaffId = @StaffId

		delete CookbookRecipe
		from CookbookRecipe cr
		join Recipe r 
		on r.RecipeId = cr.recipeid
		where StaffId = @StaffId
		--AF I think this delete statment is a mistake, you have it lower down too
		delete recipe where StaffId = @StaffId

		delete MealCourseRecipe
		from MealCourseRecipe mcr
		join MealCourse mc
		on mc.MealCourseId = mcr.MealCourseId
		join Meal m
		on m.MealId = mc.MealId
		where StaffId = @StaffId

		delete MealCourse 
		from MealCourse mc
		join Meal m
		on m.MealId = mc.MealId
		where StaffId = @StaffId

		delete CookbookRecipe
		from CookbookRecipe cr
		join Cookbook c
		on c.CookbookId = cr.CookbookId
		where StaffId = @StaffId

		delete Cookbook where StaffId = @StaffId
		delete Meal where StaffId = @StaffId
		delete Recipe where StaffId = @StaffId
		delete Staff where StaffId = @StaffId
	commit
end try

begin catch
	rollback;
	throw
end catch

	return @return
end
go

