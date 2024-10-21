namespace Medicinery.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomePageViewModel _viewModel;

    public HomePage()
    {
    }

    public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _viewModel.InitializeAsync();	
	}
}