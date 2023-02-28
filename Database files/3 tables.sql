--AS WOW!! 100%
use HearthyHearthDB
go 

drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course
drop table if exists Meal
drop table if exists RecipeDirection
drop table if exists RecipeIngredient 
drop table if exists Recipe
drop table if exists MeasurementType
drop table if exists Ingredient
drop table if exists CuisineType
drop table if exists Staff
go 

create table dbo.Staff(
    StaffId int not null identity primary key,
    FirstName varchar(50) not null 
        constraint ck_Staff_FirstName_cannot_be_blank check(FirstName <> ''), 
    LastName varchar(50) not null 
        constraint ck_Staff_LastName_cannot_be_blank check(LastName <> ''), 
    UserName varchar(30) not null 
        constraint ck_Staff_UserName_cannot_be_blank check(UserName <> '')
        constraint u_Staff_UserName unique
)
go

create table dbo.CuisineType(
    CuisineTypeId int not null identity primary key,
    CuisineTypeDesc varchar(30) not null 
        constraint ck_CuisineType_CuisineTypeDesc_cannot_be_blank check(CuisineTypeDesc <> '')
        constraint u_CuisineType_CuisineTypeDesc unique
)
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(30) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> '') 
        constraint u_Ingredient_IngredientName unique,
    IngredientPicture as concat('Ingredient', '-', replace(IngredientName, ' ', '-'), '.jpg') persisted
)
go 

create table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key,
    MeasurementTypeDesc varchar(25) not null 
        constraint ck_MeasurementType_MeasurementTypeDesc_cannot_be_blank check(MeasurementTypeDesc <> '')
        constraint u_MeasurementType_MeasurementTypeDesc unique
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    StaffId int not null 
        constraint f_Staff_Recipe foreign key references Staff(StaffId),
    CuisineTypeId int not null 
        constraint f_CuisineType_Recipe foreign key references CuisineType(CuisineTypeId),
    RecipeName varchar(50) not null 
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    Calories int not null
        constraint ck_Recipe_Calories_must_be_greater_than_zero check(Calories > 0),
    DateCreated datetime not null
        constraint ck_Recipe_DateCreated_cannot_be_before_website_was_created_and_not_in_the_future check(DateCreated between 01/01/22 and getdate()),
    DatePublished datetime null 
        constraint ck_Recipe_DatePublished_cannot_be_before_website_was_created_and_not_in_the_future check(DatePublished between 01/01/22 and getdate()),
    DateArchived datetime null 
        constraint ck_Recipe_DateArchived_cannot_be_before_website_was_created_and_not_in_the_future check(DateArchived between 01/01/22 and getdate()),
    RecipeStatus as case 
                    when DatePublished is null and DateArchived Is null then 'Draft'
                    when DatePublished is not null and DateArchived is null then 'Published'
                    when DateArchived is not null then 'Archived'
                    end persisted,
    RecipePicture as concat('Recipe', '-', replace(RecipeName, ' ', '-'), '.jpg') persisted,
    constraint ck_Recipe_DatePublished_must_be_after_dateCreated check(DateCreated < DatePublished),
    constraint ck_Recipe_DateArchived_must_be_after_DateCreated_and_DatePublished check(DateArchived > DateCreated and DateArchived > DatePublished)
)
go 

create table dbo.RecipeIngredient (
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null 
        constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null
        constraint f_Ingredient_RecipeIngredient  foreign key references Ingredient(IngredientId),
    MeasurementTypeId int null
        constraint f_MeasurmentType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
        --Reason why I think the amount should be nullable is because some ingredients don't have an amount. ex. pinch of salt
    Amount decimal(5,2) null
        constraint ck_RecipeIngredient_Amount_must_be_greater_than_zero check(Amount > 0),
    IngredientSequence int not null 
        constraint RecipeIngredient_IngredientSequence_must_be_greater_than_zero check(IngredientSequence > 0),
    constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId,IngredientId)
)
go

create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key, 
    RecipeId int not null 
        constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    DirectionDesc varchar(500) not null
        constraint ck_RecipeDirection_DirectionDesc_cannot_be_blank check(DirectionDesc <> ''),
    DirectionSequence int not null 
        constraint ck_RecipeDirection_DirectionSequence_must_be_geater_than_zero check(DirectionSequence > 0),
    constraint u_RecipeDirection_RecipeId_DirectionSequence unique(RecipeId,DirectionSequence)
)
go 

create table dbo.Meal(
    MealId int not null identity primary key,
    StaffId int not null 
        constraint f_Staff_Meal foreign key references Staff(StaffId),
    MealName varchar(50) not null 
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    DateCreated date not null
        constraint d_Meal_DateCreated default getdate()
        constraint ck_Meal_DateCreated_cannot_be_before_website_was_published_and_not_in_the_future check(DateCreated between '01/01/2022' and getdate()),
    MealActive bit not null constraint d_Meal_MealActive default(1),
    MealPicture as concat('Meal', '-', replace(MealName, ' ', '-'), '.jpg') persisted
)
go 

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(50) not null 
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> '')
        constraint u_Meal_CourseName unique,
    CourseSequence int not null
        constraint ck_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence > 0)
)
go

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null 
        constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null 
        constraint f_Course_MealCourse foreign key references Course(CourseId),
    constraint u_MealCourse_MealId_CourseId unique(MealId,CourseId)
)
go

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null 
        constraint f__MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null 
        constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null,
    constraint u_MealCourseRecipe_MealCourseId_RecipeId unique(MealCourseId,RecipeId)
)
go

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    StaffId int not null 
        constraint f_Staff_Cookbook foreign key references Staff(StaffId),
    CookbookName varchar(50) not null
        constraint ck_Cookbook_CookbookName_cannot_be_blank check(CookbookName <> '')
        constraint u_Cookbook_CookbookName unique,
    Price decimal(5,2) not null
        constraint ck_Cookbook_Price_must_be_greater_than_zero check(Price > 0),
    DateCreated date 
        constraint d_Cookbook_DateCreated default getdate()
        constraint ck_Cookbook_DateCreated_cannot_be_before_website_was_created_and_not_in_the_future check(DateCreated between '01/01/2022' and getdate()),
    CookbookActive bit not null,
    CookbookPicture as concat('Cookbook', '-', replace(CookbookName, ' ', '-'), '.jpg')
)
go

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null 
        constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null
        constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    CookbookRecipeSequence int not null
        constraint ck_CookbookRecipe_CookbookRecipeSequence_must_be_greater_than_zero check(CookbookRecipeSequence > 0),
    constraint u_CookbookRecipe_CookbookId_RecipeId unique(CookbookId,RecipeId)

)
go