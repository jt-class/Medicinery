


using Firebase.Auth;
using Medicinery.Pages;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Medicinery.ViewModels;

public class LoginViewModel : INotifyPropertyChanged
{
    private INavigation? _navigation;
    private string _email;
    private string _password;
    public string WebAPIkey = "AIzaSyAOeUXu18qCz30Tf6fYs2fp3KgTGBYAcS8";
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            OnPropertChanged(nameof(Email));
        }
    }
    public string Password
    {
        get => _password;
        set
        {
            _password = value;
            OnPropertChanged(nameof(Password));
        }

    }
    public Command Login { get; }   
    public LoginViewModel(INavigation navigation)
    {
        this._navigation = navigation;
        Login = new Command(LoginUserTappedAsysnc);
    }

    private async void LoginUserTappedAsysnc(object obj)
    {
        var authprovider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
        try
        {
            
            var auth = await authprovider.SignInWithEmailAndPasswordAsync(_email, _password);
            var cotent = await auth.GetFreshAuthAsync();
            var serlizationContent = JsonConvert.SerializeObject(cotent);
            Preferences.Set("FreshFirebaseToken", serlizationContent);
            await this._navigation.PopAsync();
            await this._navigation.PushAsync(new HomePage());
            
        }
        catch (Exception ex)
        {
            await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            throw;
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertChanged(string v) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
}
