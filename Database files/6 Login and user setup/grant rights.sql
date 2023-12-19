use RecipeDB
go

--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on RecipeUpdate to approle
grant execute on IngredientGet to approle
grant execute on RecipeGet to approle
grant execute on CourseGet to approle
grant execute on MeasurementTypeDelete to approle
grant execute on CookbookDelete to approle
grant execute on RecipeStepUpdate to approle
grant execute on IngredientDelete to approle
grant execute on RecipeDelete to approle
grant execute on CourseDelete to approle
grant execute on CloneRecipe to approle
grant execute on MeasurementTypeUpdate to approle
grant execute on RecipeStepGet to approle
grant execute on DashboardGet to approle
grant execute on CookbookUpdate to approle
grant execute on AutoCreateCookbook to approle
grant execute on MeasurementTypeGet to approle
grant execute on RecipeStepDelete to approle
grant execute on CuisineTypeUpdate to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on StaffUpdate to approle
--grant execute on MeasurementDelete to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on CuisineTypeGet to approle
grant execute on CookbookRecipeGet to approle
grant execute on StaffGet to approle
grant execute on MealGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on CuisineTypeDelete to approle
grant execute on CookbookRecipeDelete to approle
grant execute on StaffDelete to approle
grant execute on IngredientUpdate to approle
grant execute on RecipeIngredientDelete to approle
grant execute on CourseUpdate to approle
grant execute on CookbookGet to approle