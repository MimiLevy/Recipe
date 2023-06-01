using System.Data;
using System.Text;

namespace RecipeAppsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\sqlexpress;Database=RecipeDB;Trusted_Connection=true");
        }


        [Test]
        public void InsertNewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1, "Datatable has more or less than 1 row");

            int staffid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 staffid from staff");
            Assume.That(staffid > 0, "No staff, can't test");
            int cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "No cuisinetype, can't test");


            string recipename = "Test " + DateTime.Now.ToString();
            TestContext.WriteLine("Insert Recipe - " + recipename + " to DB");

            r["staffid"] = staffid;
            r["cuisinetypeid"] = cuisinetypeid;
            r["recipename"] = recipename;
            r["calories"] = 250;
            r["datecreated"] = "2000-01-01";
            Recipe.Save(dt);

            int newrecipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe where recipename =  '" + recipename + "'");
            Assert.IsTrue(newrecipeid > 0, "Recipe (" + recipename + ") is not found in DB");
            TestContext.WriteLine("Recipe (" + recipename + ") was found in DB with pk = " + newrecipeid);
        }

        [Test]
        public void ChangeExistingRecipesCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Recipe with id = " + recipeid + " has " + calories + " calories");
            calories = calories * 2;
            TestContext.WriteLine("Change calories to " + calories);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "recipe (" + recipeid + ") does not have " + newcalories + " calories");
            TestContext.WriteLine("Recipe with id = " + recipeid + " has " + newcalories + " calories");
        }

        [Test]
        public void ChangeExistingRecipesCaloriesToInvalidNumber()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
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
            string recipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid <> " + recipeid);
            string currentrecipename = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid);
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
            DataTable dt = SQLUtility.GetDataTable("select top 1 * from recipe order by recipeid desc");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "No recipes, can't test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app can delete recipe with id = " + recipeid);

            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Recipe with id = " + recipeid + " exists in DB");
            TestContext.WriteLine("Recipe with id = " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeWithIngredients()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 * from recipe order by recipeid");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "No recipes with ingredients, can't test");
            TestContext.WriteLine("Existing recipe with ingredients, with id = " + recipeid);
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

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["RecipeId"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe = " + loadedid);
        }

        [Test]
        public void SearchRecipe()
        {
            string criteria = "d";
            int num = SQLUtility.GetFirstColumnFirstRowValue("select Total = count(*) from Recipe where RecipeName like '%" + criteria + "%'");
            Assume.That(num > 0, "There are no recipes that match the search for " + criteria);
            TestContext.WriteLine("There are " + num + " recipes that match " + criteria);
            TestContext.WriteLine("Ensure  that recipe search returns " + num + " rows");

            DataTable dt = Recipe.SearchForRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of recipe search does not match number of recipes, " + results + " <> " + num);
            TestContext.WriteLine("Number of rows returnd by recipe search is " + results);
        }



        [Test]
        [TestCase("staff")]
        [TestCase("cuisinetype")]
        public void GetList(string tablename)
        {

            int listrecordscount = SQLUtility.GetFirstColumnFirstRowValue("select TotalCount = count(*) from " + tablename);
            Assume.That(listrecordscount > 0, "No records in the list, can't test");
            TestContext.WriteLine("Num of list records in DB  = " + listrecordscount);
            TestContext.WriteLine("Ensure that number of rows return by app matches = " + listrecordscount);

            DataTable dt = Recipe.GetList(tablename);

            Assert.IsTrue(dt.Rows.Count == listrecordscount, "Num rows returned by app (" + dt.Rows.Count + " <> " + listrecordscount);

            TestContext.WriteLine("Num of rows returned by app = " + dt.Rows.Count);
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
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
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}