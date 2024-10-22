using Medicinery.Services;
using System.Collections.ObjectModel;

namespace Medicinery.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private INavigation _inavigatoion;

        
        public HomePageViewModel(INavigation navigation)
        {
            this._inavigatoion = navigation;    
        }


        

       
    }
    
}
