--AS Great job! 100%
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/
use RecipeDB 
go

--One resultset with number of recipes, meals, and cookbooks
select NumOfRecipes = count (distinct r.RecipeId), NumOfMeals = count(distinct m.MealId), NumOfCookbook = count(distinct c.CookbookId)
from Recipe r 
cross join Meal m 
cross join Cookbook c 

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
*/
select r.RecipeName, r.RecipeStatus, r.DatePublished, DateArchived = isnull(r.DateArchived,' '), [User] = concat(s.FirstName, ' ', s.LastName), r.Calories, NumOfIngredients = count(ri.IngredientId)
from Recipe r
left join Staff s 
on r.StaffId = s.StaffId
left join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeStatus = 'Published'
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, s.FirstName, s.LastName, r.Calories
union select RecipeName = concat('<span style="color:gray">', r.RecipeName, '</span>'), r.RecipeStatus, r.DatePublished, r.DateArchived , [User] = concat(s.FirstName, ' ', s.LastName), r.Calories, NumOfIngredients = count(ri.IngredientId)
from Recipe r
left join Staff s 
on r.StaffId = s.StaffId
left join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
where r.RecipeStatus = 'Archived'
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, s.FirstName, s.LastName, r.Calories
order by r.RecipeStatus desc 

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
;
with x as(
   select NumOfDirections = count(*)
   from RecipeDirection rd 
   join Recipe r 
   on rd.RecipeId = r.RecipeId
   where r.RecipeName = 'Butter Muffins'
)
select r.RecipeName, r.Calories, NumOfIngredients = count(ri.RecipeIngredientId), x.NumOfDirections, r.RecipePicture
from Recipe r 
join RecipeIngredient ri 
on r.Recipeid = ri.RecipeId
cross join x 
where r.RecipeName = 'Butter Muffins'
group by r.RecipeName, r.Calories, x.NumOfDirections, r.RecipePicture

select ListOfIngredients = concat(ri.Amount, ' ', mt.MeasurementTypeDesc, ' ', i.IngredientName), i.IngredientPicture
from Recipe r 
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i 
on ri.IngredientId = i.IngredientId
join MeasurementType mt 
on ri.MeasurementTypeId = mt.MeasurementTypeId
where r.RecipeName = 'Butter Muffins'
order by ri.IngredientSequence

select rd.DirectionDesc
from Recipe r 
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Butter Muffins'
order by rd.DirectionSequence

/*
Meal list page:
    All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
;
with x as(
select m.MealName, NumOfCourses = count(mc.CourseId)
from MealCourse mc
join Meal m 
on mc.MealId = m.MealId 
group by m.MealName
)
select m.MealName, [User] = concat(s.FirstName, ' ', s.LastName), NumOfCalories = sum(r.Calories), x.NumOfCourses, NumOfRecipes =count(r.RecipeId)
from Meal m 
join x 
on m.MealName = x.MealName
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId 
join Staff s
on m.StaffId = s.StaffId
where m.MealActive = 1
group by m.MealName, s.FirstName, s.LastName, x.NumOfCourses
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, [User] = concat(s.FirstName, ' ', s.LastName), m.DateCreated, m.MealPicture
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
where m.MealName = 'Breakfast bash'

select RacipeList = 
    case when c.CourseName = 'Main' and mcr.MainDish = 1 then concat('<b>', c.CourseName ,': Main dish - ', r.RecipeName, '</b>')
    when c.CourseName = 'Main' and mcr.MainDish = 0 then concat(c.CourseName, ': Side dish - ', r.RecipeName)
    else concat(c.CourseName, ': ', r.RecipeName)
    end
from Meal m 
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr
on mc.MealCourseId = mcr.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
join Course c
on c.CourseId = mc.CourseId
where m.MealName = 'Breakfast bash'

/*
Cookbook list page:
  Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, [User] = concat(s.FirstName, ' ', s.LastName), NumOfRecipes = count(cr.RecipeId),c.CookbookPicture
from Cookbook c
join Staff s
on c.StaffId = s.StaffId
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
where c.CookbookActive = 1 
group by c.CookbookName, s.FirstName, s.LastName, c.CookbookPicture
order by c.CookbookName

/*

Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
*/
select c.CookbookName, [User] = concat(s.FirstName, ' ', s.LastName), c.DateCreated, c.Price, NumOfRecipes = count(cr.RecipeId), c.CookbookPicture
from Cookbook c 
join Staff s 
on c.StaffId = s.StaffId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
where c.CookbookName = 'Treats for two'
group by c.CookbookName, s.FirstName, s.LastName, c.DateCreated, c.Price, c.CookbookPicture

;
with x as(
    select r.RecipeName, NumOfDirections = count(rd.RecipeDirectionId)
    from Cookbook c 
    join CookbookRecipe cr 
    on c.CookbookId = cr.CookbookId
    join Recipe r 
    on cr.RecipeId = r.RecipeId
    join RecipeDirection rd 
    on r.RecipeId = rd.RecipeId
    where c.CookbookName = 'Treats for two'
    group by r.RecipeName
)
select r.RecipeName, ct.CuisineTypeDesc, NumOfIngredients = count(ri.IngredientId), x.NumOfDirections
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Recipe r 
on cr.RecipeId = r.RecipeId
join CuisineType ct 
on r.CuisineTypeId = ct.CuisineTypeId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join x 
on r.RecipeName = x.RecipeName
where c.CookbookName = 'Treats for two'
group by r.RecipeName, ct.CuisineTypeDesc, x.NumOfDirections, cr.CookbookRecipeSequence
order by cr.CookbookRecipeSequence

select distinct i.IngredientName 
from Cookbook c 
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId 
join Recipe r 
on cr.RecipeId = r.RecipeId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join Ingredient i 
on ri.IngredientId = i.IngredientId
where c.CookbookName = 'Treats for two'
and cr.CookbookRecipeSequence = 2

select rd.DirectionDesc
from Cookbook c 
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId 
join Recipe r 
on cr.RecipeId = r.RecipeId
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
where c.CookbookName = 'Treats for two'
and cr.CookbookRecipeSequence = 2
order by rd.DirectionSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
    b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system
*/
;
with x as(
select r.RecipeName, JokeRecipes = concat(upper(substring(reverse(r.RecipeName),1,1)),
substring(lower(reverse(r.RecipeName)),2,(charindex(' ',lower(reverse(r.RecipeName)))-1)),
substring(lower(reverse(r.RecipeName)),(charindex(' ',lower(reverse(r.RecipeName)))+1),100))
from CookbookRecipe cr
join Recipe r 
on cr.RecipeId = r.RecipeId
)
select x.JokeRecipes, JokeRecipePicture = concat('Recipe', '-', replace(x.JokeRecipes, ' ', '-'), '.jpg')
from x

;
with x as(
select rd.RecipeId, LastDirection = max(rd.DirectionSequence)
from RecipeDirection rd 
group by rd.RecipeId
)
select r.RecipeName, FirstIngredient = min(i.IngredientName), LastDirection = rd.DirectionDesc
from RecipeIngredient ri 
join Ingredient i 
on i.IngredientId = ri.IngredientId
join Recipe r 
on ri.RecipeId = r.RecipeId
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
join x
on rd.RecipeId = x.RecipeId
where rd.DirectionSequence = x.LastDirection
group by r.RecipeName,rd.DirectionDesc

--For site administration page:
--5 seperate reports
--a) List of how many recipes each user created per status. Show 0 if none
select [User] = concat(s.FirstName, ' ', s.LastName), r.RecipeStatus, NumOfRecipes = count(r.RecipeId)
from Staff s
left join Recipe r 
on r.StaffId = s.StaffId
group by  r.RecipeStatus, s.FirstName, s.LastName
order by [User]

--b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select [User] = concat(s.FirstName, ' ', s.LastName), NumOfRecipes = count(r.RecipeId), AvgDaysBetweenDraftAndPublished = avg(datediff(day,r.DateCreated,r.DatePublished)) 
from Recipe r  
join Staff s 
on r.StaffId = s.StaffId 
group by s.FirstName, s.LastName

 --c) List of how many meals each user created and whether they're active or inactive. Show 0 if 
select [User] = concat(s.FirstName, ' ', s.LastName), NumOfMeals = count(m.MealId), 
MealActive = case when m.MealActive = 1 then 'active' when m.MealActive = 0 then 'inactive' else null end
from Staff s
left join Meal m 
on m.StaffId = s.StaffId
group by s.FirstName, s.LastName, m.MealActive 

--d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
select [User] = concat(s.FirstName, ' ', s.LastName) , NumOfCookbooks = count(c.CookbookId), 
CookbookActive = case when c.CookbookActive = 1 then 'active' when c.CookbookActive = 0 then 'inactive' else null end 
from Staff s
left join Cookbook c  
on c.StaffId = s.StaffId
group by s.FirstName, s.LastName, c.CookbookActive

--e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, NumOfDaysBetweenDraftAndArchived = datediff(day,r.DateCreated,r.DateArchived) 
from Recipe r 
where r.DatePublished is null
and r.DateArchived is not null

--For user dashboard page:
--a) Show number of the user's recipes, meals and cookbooks.
;
with x as(
    select s.UserName, NumOfMeals = count(m.MealId)
    from Meal m 
    join Staff s 
    on m.StaffId = s.StaffId
    group by s.UserName
),
    y as(
        select s.UserName, NumOfCookBooks = count(c.CookbookId)
        from Cookbook c 
        join Staff s 
        on c.StaffId = s.StaffId
        group by s.UserName
)
select NumOfRecipes = count(r.RecipeId), x.NumOfMeals, y.NumOfCookBooks
from Staff s 
left join Recipe r  
on s.StaffId = r.StaffId
join x 
on s.UserName = x.UserName
join y 
on s.UserName = y.UserName
where s.UserName = '1234J.L.'
group by s.UserName, x.NumOfMeals, y.NumOfCookBooks

--b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
select r.RecipeName, r.RecipeStatus, NumOfHoursBetweenThisStatusAndOneBefore = 
    case 
    when r.RecipeStatus = 'draft' then null    
    else datediff(hour,
         case when r.RecipeStatus = 'Published' then r.DateCreated
         else isnull(r.DatePublished,r.DateCreated)
         end,
         case when r.RecipeStatus = 'Published' then r.DatePublished
         else r.DateArchived
         end) 
    end  
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
where s.UserName = '1234J.L.'

--c) Count of their recipes per cuisine. Show 0 for none.
select ct.CuisineTypeDesc, NumOfRecipesPerCuisine = count(r.RecipeId) 
from CuisineType ct  
left join Recipe r
on r.CuisineTypeId = ct.CuisineTypeId
left join Staff s 
on r.StaffId = s.StaffId 
where s.UserName = '1234J.L.'
group by ct.CuisineTypeDesc

