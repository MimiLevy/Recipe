using RecipeAppsSystem;
using System.Data;

namespace RecipeAppsMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}
    private void SearchRecipes()
    {
        DataTable dt = Recipe.SearchForRecipes(RecipeNameTxt.Text);
        RecipeLst.ItemsSource = dt.Rows;
    }
    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }


}