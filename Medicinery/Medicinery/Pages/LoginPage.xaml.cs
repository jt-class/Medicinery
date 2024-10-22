namespace Medicinery.Pages;

public partial class LoginPage : ContentPage
{
    
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(Navigation);
    }
    private async void SignUp(Object sender, EventArgs e) {
        await Navigation.PushModalAsync(new SignUpPages());
    }
    
}   