/*
--AS Amazing job!! 100% See one comment, no need to resubmit.

Sketch:
User
    FirstName varchar(50) not null not blank 
    LastName varchar(50) not null not blank 
    UserName varchar(30) not null not blank unique

CuisineType
    CuisineTypeDesc varchar(30) not null not blank unique

Ingredient
    IngredientName varchar(30) not null not blank unique
    IngredientPicture (Computed column)

MeasurementType
    MeasurementTypeDesc varchar(25) null not blank unique

Recipe
    UserId (fk user) int not null 
    CuisineTypeId (fk cuisine) int not null unique
    RecipeName varchar(50) not null not blank unique
    Calories int not null
        constraint Calories must be greater than 0
    DateCreated datetime not null
        constraint DateCreated cannot be before website was created and not in the future
    DatePublished datetime null
        constraint DatePublished cannot be before website was created and not in the future
    DateArchived datetime null
        constraint DateArchived cannot be before website was created and not in the 
    RecipeStatus (computed column)
    RecipePicture (Computed column)
    constraint date published must be after date created
    constraint date archived must be after date created and date published 

RecipeIngredient 
    RecipeId (fk recipe) int not null
    IngredientId (fk ingredient) not null
    MeasurementTypeId (fk MeasurementType) not null
    MeasurementAmount decimal not null
        constraint MeasurementAmount must be greater than 0
    IngredientSequence int not null
        constraint IngredientSequence must be greater than 0
    constraint RecipeId and IngredientId must be unique


RecipeDirection
    RecipeId (fk recipe) int not null
    DirectionDesc varchar(100) not null not blank
    DirectionSequnece int not null 
        constraint DirectionSequnece must be greater than 0
    constraint RecipeId and DirectionSequnece must be unique

Meal
    UserId (fk user) int not null
    MealName varchar(50) not null not blank 
    DateCreated Date not null 
        constraint DateCreated default... 
        constraint DateCreated cannot be before website was created and not in the future
    MealPicture (Computed column)
    MealActive bit not null 


Course
    CourseName varchar(25) not null not blank unique
    Sequence int not null
        constraint Sequence must be greater than 0


MealCourse
    MealId (fk Meal) int not null
    CourseId (fk course) int not null
        unique MealId and CourseId


MealCourseRecipe
    MealCourseId (fk mealcourse) int not null
    RecipeId (fk recipe) int not null
    MainDish bit not null 
    constraint MealCourse and RecipeId must be unique


Cookbook
    UserId (fk user) int not null
    CookbookName varchar(50) not null not blank unique
    Price decimal not null
        constraint Price must be greater than 0
    DateCreated date
        constraint DateCreated default... 
        constraint DateCreated cannot be before website was created and not in the future
    CookbookPicture (Computed column)
    CookbookActive bit not null


CookbookRecipe
    CookbookId (fk cookbook)
    RecipeId (fk recipe)
    CookbookRecipeSequence int not null
        constraint CookbookRecipeSequence must be greater than 0    
        unique CookbookId and RecipeId
*/