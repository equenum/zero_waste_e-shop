using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroWasteShop.Website.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        // TODO - Delete this category test dummy data later after database implementation.

        public IEnumerable<Category> GetAllCategories => new List<Category> {
            new Category( 1, "Trash reducing product", "Helps to reduce trash production from everyday life activities" ),
            new Category( 2, "Cleaning product", "Household cleaning product / instrument"),
            new Category( 3, "Recycled product", "Product made from recycled materials")
        };
    }
}
