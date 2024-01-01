--AS Fantastic job!! 100%
use RecipeDB
go 

delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Course
delete Meal
delete RecipeStep
delete RecipeIngredient 
delete Recipe
delete MeasurementType
delete Ingredient
delete CuisineType
delete Staff
go 

insert Staff(FirstName,LastName,UserName)
select 'John', 'Lewis', '1234J.L.'
union select 'Michael', 'Kors', 'M.K.LoveFood'
union select 'Anna', 'Klein', 'A.K.210'
union select 'Ted', 'Baker', '1980Ted'
go 


insert CuisineType(CuisineTypeDesc)
select 'American'
union select 'French'
union select 'English'
union select 'Jewish'
union select 'Japan'
go 

insert Ingredient(IngredientName)
select 'sugar'
union select 'oil'
union select 'egg'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'
union select 'baking soda'
union select 'chocolate chips'
union select 'granny smith apples'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cubes'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'cloves garlic'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'chicken quarter'
union select 'grape juice'
union select 'wine'
union select 'potato'
union select 'heavy whipping cream'
union select 'sweetened condensed milk'
union select 'vanilla extract'
union select 'fresh burger'
union select 'onion and garlic dip'
union select 'guacamole'
union select 'crusty roll'
union select 'tomatoe'
union select 'juicy orange'
union select 'lemon'
union select 'chicken breast'
union select 'teriyaki sauce'
union select 'canned pineapple'
union select 'rice'
union select 'soup powder'
union select 'hot water'
union select 'zucchini'
union select 'cabbage'
union select 'celery with the leaves'
union select 'red onion'
union select 'onion'
go 

insert MeasurementType(MeasurementTypeDesc)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'oz'
union select 'pinch'
union select 'stick'
union select 'to taste'
union select 'gram'
go 

;
with x as(
   select FirstName = 'Michael', LastName = 'Kors', CuisineType = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 249, DateDrafted = '01/02/22', DatePublished = '01/04/22', DateArchived = '06/18/23'
   union select 'John', 'Lewis', 'French', 'Apple Yogurt Smoothie', 431, '05/27/2022', null, null
   union select 'Ted', 'Baker', 'English', 'Cheese Bread', 71, '02/12/2022', '02/25/2022', '04/29/2022'
   union select 'Michael', 'Kors',  'American', 'Butter Muffins', 189, '04/07/2022', '05/05/2022', null
   union select 'Anna', 'Klein', 'Jewish', 'Chicken cooked in wine', 327, '03/01/2022', '03/04/2022', null
   union select 'Anna', 'Klein', 'Jewish', 'Potato Kugel', 244, '04/16/2022', null, '04/22/2022'
   union select 'Michael', 'Kors',  'American', 'Easy homemade Ice Cream', 160, '03/22/2022', '04/10/2022', null
   union select 'Michael', 'Kors',  'American', 'Tasty topped BBQ Burgers', 453, '01/05/2022', '01/15/2022', null
   union select 'John', 'Lewis',  'Japan', 'Cold Orange Juice Drink', 110, '05/22/2022', '05/26/2022', null
   union select 'John', 'Lewis', 'French', 'Teriyaki Schnitzle', 216, '05/26/2022', null, '06/15/2022'
   union select 'John', 'Lewis',  'Japan', 'Baked rice', 362, '01/27/2022', '02/27/2022', '03/27/2022'
   union select 'Ted', 'Baker', 'English', 'Vegetable Soup', 67, '06/20/2022', null, null
)
insert Recipe(StaffId,CuisineTypeId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select s.StaffId, ct.CuisineTypeId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Staff s 
on x.FirstName = s.FirstName
and x.LastName = s.LastName
join CuisineType ct 
on x.CuisineType = ct.CuisineTypeDesc
go 
 
;
with x as( 
   select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'sugar', MeasurementType = 'cup' , Amount = 1, IngredientSequence = 1
   union select 'Chocolate Chip Cookies', 'oil', 'cup', 0.5, 2
   union select 'Chocolate Chip Cookies', 'egg', null, 3, 3
   union select 'Chocolate Chip Cookies', 'flour', 'cup', 2, 4
   union select 'Chocolate Chip Cookies', 'vanilla sugar', 'tsp', 1, 5
   union select 'Chocolate Chip Cookies', 'baking powder', 'tsp', 2, 6
   union select 'Chocolate Chip Cookies', 'baking soda', 'tsp', 0.5, 7
   union select 'Chocolate Chip Cookies', 'chocolate chips', 'cup', 1, 8
   union select 'Apple Yogurt Smoothie', 'granny smith apples', null, 3, 1
   union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 'cup', 2, 2
   union select 'Apple Yogurt Smoothie', 'sugar', 'tsp', 2, 3
   union select 'Apple Yogurt Smoothie', 'orange juice', 'cup', 0.5, 4
   union select 'Apple Yogurt Smoothie', 'honey', 'tbsp', 2, 5
   union select 'Apple Yogurt Smoothie', 'ice cubes', null, 5, 6
   union select 'Cheese Bread', 'club bread', null, 1, 1
   union select 'Cheese Bread', 'butter', 'oz', 4, 2
   union select 'Cheese Bread', 'shredded cheese', 'oz', 8, 3
   union select 'Cheese Bread', 'cloves garlic', null, 2, 4
   union select 'Cheese Bread', 'black pepper', 'tsp', 0.25, 5
   union select 'Cheese Bread', 'salt', 'pinch', null, 6
   union select 'Butter Muffins', 'butter', 'stick', 1, 1
   union select 'Butter Muffins', 'sugar', 'cup', 3, 2
   union select 'Butter Muffins', 'vanilla pudding', 'tbsp', 2, 3
   union select 'Butter Muffins', 'egg', null, 4, 4
   union select 'Butter Muffins', 'whipped cream cheese', 'oz', 8, 5
   union select 'Butter Muffins', 'sour cream cheese', 'oz', 8, 6
   union select 'Butter Muffins', 'flour', 'cup', 1, 7
   union select 'Butter Muffins', 'baking powder', 'tsp', 2, 8   
   union select 'Chicken cooked in wine', 'chicken quarter', null, 4, 1
   union select 'Chicken cooked in wine', 'grape juice', 'cup', 0.5, 2
   union select 'Chicken cooked in wine', 'wine', 'cup', 0.5, 3
   union select 'Chicken cooked in wine', 'onion', null, 1, 4
   union select 'Chicken cooked in wine', 'salt' , 'tbsp', 1, 5
   union select 'Potato Kugel', 'potato', null, 6, 1
   union select 'Potato Kugel', 'onion', null, 1, 2
   union select 'Potato Kugel', 'egg', null, 4, 3
   union select 'Potato Kugel', 'oil', 'cup', 0.25, 4
   union select 'Potato Kugel', 'salt', 'to taste', null, 5   
   union select 'Potato Kugel', 'black pepper', 'to taste', null, 6
   union select 'Easy homemade Ice Cream', 'heavy whipping cream', 'cup', 2, 1
   union select 'Easy homemade Ice Cream', 'sweetened condensed milk', 'oz', 14, 2
   union select 'Easy homemade Ice Cream', 'vanilla extract', 'tsp', 1, 3
   union select 'Tasty topped BBQ Burgers', 'fresh burger', null, 4, 1
   union select 'Tasty topped BBQ Burgers', 'onion and garlic dip', 'gram', 200, 2
   union select 'Tasty topped BBQ Burgers', 'guacamole', 'gram', 200, 3
   union select 'Tasty topped BBQ Burgers', 'crusty roll', null, 4, 4
   union select 'Tasty topped BBQ Burgers', 'tomatoe', null, 2, 5
   union select 'Tasty topped BBQ Burgers', 'red onion', null, 1, 6
   union select 'Cold Orange Juice Drink', 'juicy orange', null, 5, 1
   union select 'Cold Orange Juice Drink', 'lemon', null, 0.5, 2
   union select 'Teriyaki Schnitzle', 'chicken breast', null, null, 1
   union select 'Teriyaki Schnitzle', 'teriyaki sauce', 'cup', 0.75, 2
   union select 'Teriyaki Schnitzle', 'canned pineapple', null, 1, 3
   union select 'Teriyaki Schnitzle', 'onion', null, 1, 4
   union select 'Teriyaki Schnitzle', 'Salt', 'to taste', null, 5
   union select 'Baked Rice', 'rice', 'cup', 1, 1
   union select 'Baked Rice', 'soup powder', 'tsp', 2, 2
   union select 'Baked Rice', 'salt', 'tbsp', 1, 3
   union select 'Baked Rice', 'black pepper', 'tsp', 1, 4
   union select 'Baked Rice', 'hot water', 'cup', 2, 5
   union select 'Vegetable Soup', 'zucchini', null, 2, 1
   union select 'Vegetable Soup', 'potato', null, 2, 2
   union select 'Vegetable Soup', 'cabbage', null, 0.25, 3
   union select 'Vegetable Soup', 'onion', null, 1, 4
   union select 'Vegetable Soup', 'celery with the leaves', null, 1, 5
   union select 'Vegetable Soup', 'salt', 'pinch', null, 6
)
insert RecipeIngredient(RecipeId,IngredientId,MeasurementTypeId,Amount,Sequence)
select r.RecipeId, i.IngredientId, mt.MeasurementTypeId, x.Amount, x.IngredientSequence
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Ingredient i 
on x.IngredientName = i.IngredientName
left join MeasurementType mt 
on x.MeasurementType = mt.MeasurementTypeDesc
go 

;
with x as(
   select RecipeName = 'Chocolate Chip Cookies', StepDesc = 'mix well', Sequence = 1
   union select 'Chocolate Chip Cookies', 'add flour, vanilla sugar, baking powder and baking soda', 2
   union select 'Chocolate Chip Cookies', 'beat for 5 minutes', 3 
   union select 'Chocolate Chip Cookies', 'add chocolate chips', 4
   union select 'Chocolate Chip Cookies', 'freeze for 1-2 hours', 5
   union select 'Chocolate Chip Cookies', 'roll into balls and place spread out on a cookie sheet', 6
   union select 'Chocolate Chip Cookies', 'bake on 350 for 10 min', 7 
   union select 'Apple Yogurt Smoothie', 'Peel the apples and dice', 1
   union select 'Apple Yogurt Smoothie', 'Combine all ingredients in bowl except for apples and ice cubes', 2
   union select 'Apple Yogurt Smoothie', 'mix until smooth', 3
   union select 'Apple Yogurt Smoothie', 'add apples and ice cubes', 4
   union select 'Apple Yogurt Smoothie', 'pour into glasses', 5
   union select 'Cheese Bread', 'Slit bread every 0.75 inch', 1
   union select 'Cheese Bread', 'Combine all ingredients in bowl the garlic should be crushed', 2
   union select 'Cheese Bread', 'fill slits with cheese mixture', 3
   union select 'Cheese Bread', 'wrap bread into a foil and bake for 30 minutes', 4
   union select 'Butter Muffins', 'Cream butter with sugars', 1
   union select 'Butter Muffins', 'Add eggs and mix well', 2
   union select 'Butter Muffins', 'Slowly add rest of ingredients and mix well', 3
   union select 'Butter Muffins', 'fill muffin pans 3/4 full and bake for 30 minutes', 4 
   union select 'Chicken cooked in wine', 'Slice the onions and lightly fry them', 1  
   union select 'Chicken cooked in wine', 'Put the chicken over the onion and sprinkle with a little salt', 2            
   union select 'Chicken cooked in wine', 'After a few minutes add the wine and grape juice', 3           
   union select 'Chicken cooked in wine', 'Cook on low heat for about an hour', 4   
   union select 'Potato Kugel', 'Grate the potatoes and onion and place in a bowl', 1
   union select 'Potato Kugel', 'Add the oil, eggs, salt and pepper to taste', 2
   union select 'Potato Kugel', 'Mix well and pour into 2 English cake tins', 3
   union select 'Potato Kugel', 'Bake on 350 for about 45 minutes, or until the kugel gets a golden hue that tends to brown', 4  
   union select 'Easy homemade Ice Cream', 'In a large bowl, use a hand mixer or a stand mixer to whip the cream until stiff peaks occur', 1
   union select 'Easy homemade Ice Cream', 'In another large bowl, whisk the vanilla into the sweetened condensed milk', 2            
   union select 'Easy homemade Ice Cream', 'Slowly incorporating the two mixtures together so it stays light and aerated', 3           
   union select 'Easy homemade Ice Cream', 'If making individual flavors, scoop the cream mixture into smaller bowls and gently fold in your desired mix-ins', 4            
   union select 'Easy homemade Ice Cream', 'If making just one flavor, mix the ingredients directly into the cream mixture', 5 
   union select 'Easy homemade Ice Cream', 'Put the mixture into paper containers and freeze for 4-6 hours', 6
   union select 'Tasty topped BBQ Burgers', 'Cook the burgers over hot barbecue coals or under a grill for 8-10mins, turning once until theyre are cooked through', 1   
   union select 'Tasty topped BBQ Burgers', 'Meanwhile spoon the dips into serving bowls', 2 
   union select 'Tasty topped BBQ Burgers', 'Slice the tomato and red onion and put it in a serving plate', 3                
   union select 'Tasty topped BBQ Burgers', 'If liked, lightly toast the crusty rolls over the coals', 4             
   union select 'Cold Orange Juice Drink', 'Cut the oranges in half', 1              
   union select 'Cold Orange Juice Drink', 'Squeeze the oranges and lemon as much as possible', 2       
   union select 'Cold Orange Juice Drink', 'If necessary strain the juice', 3             
   union select 'Cold Orange Juice Drink', 'Put in the fridge, and serve cold with ice cubes', 4  
   union select 'Teriyaki Schnitzle', 'Drain the canned goods with the juice into a bowl', 1                 
   union select 'Teriyaki Schnitzle', 'Add the teriyaki sauce and salt to taste', 2                
   union select 'Teriyaki Schnitzle', 'Put the breast in the sauce and cover it on all sides', 3                
   union select 'Teriyaki Schnitzle', 'Leave the chicken in the sauce for 10 minutes', 4                
   union select 'Teriyaki Schnitzle', 'Meanwhile, slice the onions and fry them', 5
   union select 'Teriyaki Schnitzle', 'put the chicken breast on the onions aand fry both sides until it is lightly greased', 6
   union select 'Baked Rice', 'Put in a pan the amount of rice you want, it is recommended to measure in a cup', 1              
   union select 'Baked Rice', 'Add soup powder, black pepper and salt to taste', 2             
   union select 'Baked Rice', 'Add the hot water', 3             
   union select 'Baked Rice', 'Cover the pan with parchment paper and foil on top so that it doesnt carry toxins', 4             
   union select 'Baked Rice', 'Bake on 350 for 40 minutes', 5             
   union select 'Vegetable Soup', 'Cut the onion into cubes and fry with a little oil', 1             
   union select 'Vegetable Soup', 'Grate all the vegetables on a coarse grater', 2               
   union select 'Vegetable Soup', 'Chop the celery and dill', 3                 
   union select 'Vegetable Soup', 'Add everything to the pot with water covering all the vegetables', 4                 
   union select 'Vegetable Soup', 'Add spices and cook for about 40 minutes', 5                 
   union select 'Vegetable Soup', 'Chicken can be added for those who want meat soup ', 6
)
insert RecipeStep(RecipeId,StepDesc,Sequence)
select r.RecipeId, x.StepDesc, x.Sequence 
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
go 

;
with x as(
   select UserName = '1234J.L.', MealName = 'Breakfast bash', MealActive = 1
   union select 'M.K.LoveFood', 'BBQ Supper', 1
   union select 'A.K.210', 'Shabbes meal', 0
   union select 'M.K.LoveFood', 'Good Easy Supper', 1
)
insert Meal(StaffId,MealName,MealActive)
select s.StaffId, x.MealName, x.MealActive
from x 
join Staff s 
on x.UserName = s.UserName
go 

insert Course(CourseName,Sequence)
select 'Appetizer', 1
union select 'Soup', 2
union select 'Main', 3
union select 'Dessert', 4
go 

;
with x as(
   select MealName = 'Breakfast bash', CourseName = 'Main'
   union select 'Breakfast bash', 'Appetizer'
   union select 'Shabbes meal', 'Main'
   union select 'Shabbes meal', 'Dessert'
   union select 'BBQ Supper', 'Main'   
   union select 'BBQ Supper', 'Appetizer'
   union select 'Good Easy Supper', 'Main'
   --union select 'Good Easy Supper', 'Soup'     
)
insert MealCourse(MealId,CourseId)
select m.MealId, c.CourseId
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
go 

;
with x as(
   select MealName = 'Breakfast bash', CourseName = 'Main', RecipeName = 'Cheese Bread', MainDish = 1
   union select 'Breakfast bash', 'Main', 'Butter Muffins', 0
   union select 'Breakfast bash', 'Appetizer', 'Apple Yogurt Smoothie', 1 
   union select 'Shabbes meal', 'Main', 'Chicken cooked in wine', 1
   union select 'Shabbes meal', 'Main', 'Potato Kugel', 0
   union select 'Shabbes meal', 'Dessert', 'Easy homemade Ice Cream', 1
   union select 'BBQ Supper', 'Main', 'Tasty topped BBQ Burgers', 1
   union select 'BBQ Supper', 'Appetizer', 'Cold Orange Juice Drink', 1
   union select 'Good Easy Supper', 'Main', 'Teriyaki Schnitzle', 1
   union select 'Good Easy Supper', 'Main', 'Baked rice', 0
   --union select 'Good Easy Supper', 'Soup', 'Vegetable soup', 1
)
insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select mc.MealCourseId, r.RecipeId, x.MainDish 
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
join MealCourse mc 
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId
join Recipe r 
on x.RecipeName = r.RecipeName
go 

;
with x as(
   select UserName = '1234J.L.', CookbookName = 'Treats for two', Price = 30, CookbookActive = 1
   union select '1980Ted', 'Good Food', 36, 0
   union select 'A.K.210', 'Delicius Shabbes Food', 40, 1
   union select '1980Ted', 'Yummmmm', 25, 0
)
insert Cookbook(StaffId,CookbookName,Price,CookbookActive)
select s.StaffId, x.CookbookName, x.Price, x.CookbookActive 
from x 
join Staff s
on x.UserName = s.UserName
go 

;
with x as(
   select CookbookName = 'Treats for two', RecipeName = 'Apple Yogurt Smoothie', Sequence = 1 
   union select 'Treats for two', 'Cheese Bread', 2
   union select 'Treats for two', 'Butter Muffins', 3
   --union select 'Good Food', 'Vegetable Soup', 1
   union select 'Good Food', 'Tasty topped BBQ Burgers', 1 
   union select 'Good Food', 'Teriyaki Schnitzle', 2 
   union select 'Delicius Shabbes Food', 'Chicken cooked in wine', 1
   union select 'Delicius Shabbes Food', 'Potato Kugel', 2
   union select 'Delicius Shabbes Food', 'Easy homemade Ice Cream', 3
   union select 'Yummmmm', 'Cold Orange Juice Drink', 1
   union select 'Yummmmm', 'Baked Rice', 2   
)
insert CookbookRecipe(CookbookId,RecipeId,Sequence)
select c.CookbookId, r.RecipeId, x.Sequence
from x 
join Cookbook c
on x.CookbookName = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName
go 