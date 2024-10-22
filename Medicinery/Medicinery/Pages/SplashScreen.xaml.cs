
using System.Timers;

namespace Medicinery.Pages;

public partial class SplashScreen : ContentPage
{
    private System.Timers.Timer? _navigationTimer;
    public SplashScreen()
	{
        InitializeComponent();
        StartNavigationTimer();
    }
    private void StartNavigationTimer()
    {
        _navigationTimer = new System.Timers.Timer(2000);
        _navigationTimer.Elapsed += OnTimedEvent;
        _navigationTimer.AutoReset = false;
        _navigationTimer.Start();
    }
    private void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
        _navigationTimer?.Stop();
        _navigationTimer?.Dispose();

        Dispatcher.Dispatch(async () =>
        {
            await Navigation.PushAsync(new SelectionPage());
        });
    }

    private async void OnFrameTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectionPage());
    }

    
}