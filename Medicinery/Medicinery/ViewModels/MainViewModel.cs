namespace Medicinery.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private IEnumerable<Categories> _category;

        public MainViewModel()
        {
            Category = LoudCategory();
        }

        private static IEnumerable<Categories> LoudCategory()
        {
            return new List<Categories>
            {
                new Categories(1, "", ""),
                new Categories(2, "", ""),
                new Categories(3, "", ""),
                new Categories(4, "", ""),
                new Categories(5, "", ""),
                new Categories(6, "", ""),
                new Categories(7, "", ""),

            };
        }
    }

}
