namespace Medicinery.Pages;

public partial class SelectionPage : ContentPage
{
	public SelectionPage()
	{
		InitializeComponent();
	}
	public async void ShoppersLogin(Object sender, EventArgs args ) {
		await Navigation.PushModalAsync(new LoginPage());

    }
	public async void DriversLogin(Object sender, EventArgs args) {
		await Navigation.PushModalAsync(new DriversLogin());
	}

}