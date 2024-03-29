using System.Configuration;
using System.Data;

namespace RecipeAppsTest
{
    public class Tests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(connstring, true);
        }
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }


        [Test]
        public void InsertNewRecipe()
        {
            int staffid = GetFirstColumnFirstRowValue("select top 1 staffid from staff");
            Assume.That(staffid > 0, "No staff, can't test");
            int cuisinetypeid = GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "No cuisinetype, can't test");
            string recipename = "Test " + DateTime.Now.ToString();
            TestContext.WriteLine("Insert Recipe - " + recipename + " to DB");

            BizRecipe recipe = new();
            recipe.StaffId = staffid;
            recipe.CuisineTypeId = cuisinetypeid;
            recipe.RecipeName = recipename;
            recipe.Calories = 250;
            recipe.DateDrafted = DateTime.Now.AddYears(-10);
            recipe.DatePublished = DateTime.Now.AddYears(-8);
            recipe.Save();

            int newrecipeid = GetFirstColumnFirstRowValue("select recipeid from recipe where recipename =  '" + recipename + "'");
            Assert.IsTrue(newrecipeid > 0, "Recipe (" + recipename + ") is not found in DB");
            TestContext.WriteLine("Recipe (" + recipename + ") was found in DB with pk = " + newrecipeid);
        }

        [Test]
        public void ChangeExistingRecipesCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Recipe with id = " + recipeid + " has " + calories + " calories");
            calories = calories * 2;
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "recipe (" + recipeid + ") does not have " + newcalories + " calories");
            TestContext.WriteLine("Recipe with id = " + recipeid + " has " + newcalories + " calories");
        }

        [Test]
        public void ChangeExistingRecipesCaloriesToInvalidNumber()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Recipe with id = " + recipeid + " has " + calories + " calories");
            calories = 0;
            TestContext.WriteLine("Change calories to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipesNameToInvalidName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            string? recipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid <> " + recipeid);
            string? currentrecipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Change recipe name from " + currentrecipename + " to different recipe name - " + recipename);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            InsertNewRecipe();
            DataTable dt = GetDataTable("select top 1 * from recipe order by recipeid desc");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "No recipes, can't test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);
            BizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe with id = " + recipeid + " exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeWithIngredients()
        {
            DataTable dt = GetDataTable("select top 1 * from recipe order by recipeid");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "No recipes with ingredients, can't test");
            TestContext.WriteLine("Existing recipe with ingredients, with id = " + recipeid);
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeletePublishedRecipeWithIngredients()
        {
            //           string sql = @"
            //select top 1 @recipeid = r.recipeid
            //from Recipe r
            //join RecipeIngredient ri
            //on ri.RecipeId = r.RecipeId
            //join RecipeDirection rd 
            //on rd.RecipeId = r.RecipeId
            //left join mealcourserecipe mcr
            //on mcr.RecipeId = r.RecipeId
            //left join CookbookRecipe cr 
            //on cr.recipeid = r.recipeid
            //where mcr.RecipeId is null
            //and cr.RecipeId is null
            //and r.RecipeStatus <> 'draft'
            //or (r.RecipeStatus <> 'archived' and datediff(day, r.DateArchived, getdate()) >=  30)
            //order by r.RecipeId desc
            //";
            DataTable dt = GetDataTable("select top 1 * from recipe order by recipeid");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "No published recipes with ingredients, can't test");
            TestContext.WriteLine("Existing published recipe with ingredients, with id = " + recipeid);
            TestContext.WriteLine("Ensure that app cannot delete recipe with id = " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe with id = " + recipeid);
            BizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            string recipename = recipe.RecipeName;
            Assert.IsTrue(loadedid == recipeid && recipename != "", loadedid + " <> " + recipeid + ", RecipeName = " + recipename);
            TestContext.WriteLine("Loaded recipe = " + loadedid + ", RecipeName = " + recipename);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "d";
            int count = GetCountOfRecordsForCriteria("Recipe", "RecipeName", criteria);

            BizRecipe r = new();
            var lst = r.Search(criteria);

            Assert.IsTrue(lst.Count == count, "Results of recipe search does not match number of recipes, " + lst.Count + " <> " + count);
            TestContext.WriteLine("Number of rows returnd by recipe search is " + lst.Count);
        }

        [Test]
        public void SearchIngredient()
        {
            string criteria = "f";
            int count = GetCountOfRecordsForCriteria("Ingredient", "IngredientName", criteria);

            bizIngredient i = new();
            var lst = i.Search(criteria);

            Assert.IsTrue(lst.Count == count, "Results of recipe search does not match number of recipes, " + lst.Count + " <> " + count);
            TestContext.WriteLine("Number of rows returnd by recipe search is " + lst.Count);
        }


        [Test]
        [TestCase("staff")]
        [TestCase("cuisinetype")]
        public void GetList(string tablename)
        {

            int listrecordscount = GetCountOfRecords(tablename, false);

            DataTable dt = Recipe.GetList(tablename);

            Assert.IsTrue(dt.Rows.Count == listrecordscount, "Num rows returned by app (" + dt.Rows.Count + " <> " + listrecordscount);

            TestContext.WriteLine("Num of rows returned by app = " + dt.Rows.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = GetCountOfRecords("Recipe", includeblank);

            BizRecipe r = new();
            var lst = r.GetList(includeblank);

            Assert.IsTrue(lst.Count == recipecount, "Num rows returned by app (" + lst.Count + " <> " + recipecount);

            TestContext.WriteLine("Num of rows returned by app = " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int recipecount = GetCountOfRecords("Ingredient", includeblank);

            bizIngredient i = new();
            var lst = i.GetList(includeblank);

            Assert.IsTrue(lst.Count == recipecount, "Num rows returned by app (" + lst.Count + " <> " + recipecount);

            TestContext.WriteLine("Num of rows returned by app = " + lst.Count);
        }

        private int GetCountOfRecords(string tablename, bool includeblank)
        {
            int tablerecordscount = GetFirstColumnFirstRowValue("select TotalCount = count(*) from " + tablename);
            if (includeblank == true) { tablerecordscount = tablerecordscount + 1; }
            Assume.That(tablerecordscount > 0, "No records in the list, can't test");
            TestContext.WriteLine("Num of list records in DB  = " + tablerecordscount);
            TestContext.WriteLine("Ensure that number of rows return by app matches = " + tablerecordscount);
            return tablerecordscount;
        }
        private int GetCountOfRecordsForCriteria(string tablename, string columnname,string criteria)
        {
            int count = GetFirstColumnFirstRowValue($"select Total = count(*) from {tablename} where {columnname} like '%{criteria}%'");
            Assume.That(count > 0, "There are no recipes that match the search for " + criteria);
            TestContext.WriteLine("There are " + count + " recipes that match " + criteria);
            TestContext.WriteLine("Ensure  that recipe search returns " + count + " rows");
            return count;
        }

        private string? GetFirstColumnFirstRowValueAsString(string sql)
        {
            string? s = "";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}