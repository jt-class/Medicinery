namespace Medicinery;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SignUpPages : ContentPage
{
	public SignUpPages()
	{
		InitializeComponent();
		BindingContext = new SignUpViewModel(Navigation);

    }
}