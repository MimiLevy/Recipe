/*
Recipe Website spec
we have recipes, meales, cookbooks... very pupular website

Recipes:
recipe name unique
*Cuisine Type unique
*ingredients, name unique, measurement type, amount, sequence
directions in num order
calories
*Recipe status: draft, published, archived, +date and time

Meales:
name unique, each meal can have multipule courses but not with same course type (if it's the same course type it should be two recipes in the course with sequence)
*courses: *course type(apitizer, main, etc...), each course can have multipule recipes, Course sequence, recipes, recipe sequence, *recipe desc(main dish, side dish etc...)
Date created

Cookbook:
name unique
price
recipes
sequence
date created

Picture:
name: type-nameof ingredient.jpg

StaffMember:
firstname
lastname
user name
*/