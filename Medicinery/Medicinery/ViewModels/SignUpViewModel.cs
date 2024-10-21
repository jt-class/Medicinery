


using Firebase.Auth;
using System.ComponentModel;

namespace Medicinery.ViewModels;

public class SignUpViewModel : INotifyPropertyChanged
{
    private INavigation _navigation;
    private string _userName;
    private string _email;
    private string _password;
    public string WebAPIkey = "AIzaSyAOeUXu18qCz30Tf6fYs2fp3KgTGBYAcS8";


    public string Username {
        get =>_email;
        set {   
            _email = value; 
        }
    }
    public string Email {
        get => _email;
        set
        {
            _email = value;
            OnPropertChanged(nameof(Email));
        }
    }
    public string Password { 
        get => _password;
        set
        {
            _password = value;
            OnPropertChanged(nameof(Password));
        }
    }
        
    public Command SignUp{  get;  }
    public SignUpViewModel(INavigation navigation) {
        this._navigation = navigation;
        SignUp = new Command(RegisterUserTappedAsysnc);
    }

    private async void RegisterUserTappedAsysnc(object obj)
    {
        try { 
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
            var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(_email, _password);
            string token = auth.FirebaseToken;
            if (token != null) {
                await App.Current.MainPage.DisplayAlert("Alert!", "User Registerd Successfully ","OK");
                await this._navigation.PushModalAsync(new LoginPage());
            }


        } 
        catch (Exception ex) {
            await App.Current.MainPage.DisplayAlert("Alert!", ex.Message, "OK");
            throw;
        }
        
        
    }
   
    public event PropertyChangedEventHandler? PropertyChanged;
    void OnPropertChanged(string v)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
    }
}
