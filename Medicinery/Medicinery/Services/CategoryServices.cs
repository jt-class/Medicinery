using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicinery.Services
{
    public class CategoryServices
    {
        private IEnumerable<Categories> _categories;
        public async ValueTask<IEnumerable<Categories>> GetCategoriesAync()
        {
            if (_categories is null)
            {

                var categories = new List<Categories>();

                var supplements = new List<Categories>
            {
                new (1, "Supplements", 0, "Supplements.png", "Photo by <a href=\"https://unsplash.com/photos/a-close-up-of-pills-and-pills-on-a-table-fIO2VfChf1w")
            };

                categories.AddRange(supplements);
                _categories = categories;
            }
            return _categories;
        }
        public async ValueTask<IEnumerable<Categories>> GetCategoriesAsync() =>
                (await GetCategoriesAync()).Where(c => c.ParentId == 0);
    }

}
