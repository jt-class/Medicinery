using Medicinery.Services;
using System.Collections.ObjectModel;

namespace Medicinery.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly CategoryServices _categoryServices;

        public HomePageViewModel(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public ObservableCollection <Categories> Categories { get; set; }
        public async Task InitializeAsync()
        {
            foreach (var categories in await _categoryServices.GetCategoriesAsync())
            {
                Categories.Add(categories);
            }
        }

    }

}
