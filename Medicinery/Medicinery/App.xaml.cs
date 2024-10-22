using Medicinery.Pages;

namespace Medicinery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }
        

        
    }
}
