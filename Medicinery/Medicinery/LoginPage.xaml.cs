namespace Medicinery;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    private void OnSignInButtonTapped(object sender, EventArgs e)
    {
        // Handle button tap
        Console.WriteLine("Sign In button tapped!");
    }
}