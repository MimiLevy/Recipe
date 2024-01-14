using RecipeAppsSystem;

namespace RecipeAppsMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void LoginBtn_Clicked(object sender, EventArgs e)
    {
        if(App.LoggedIn == false)
        {
            try
            {
                MassegeLbl.Text = "";
                DBManager.SetConnectionString(App.ConnStringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
                App.LoggedIn = true;
                await Navigation.PopModalAsync();
            }
            catch(Exception ex)
            {
                MassegeLbl.Text = ex.Message;
            }
        }
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}