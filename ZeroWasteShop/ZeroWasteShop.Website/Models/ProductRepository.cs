using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroWasteShop.Website.Models
{
    public class ProductRepository : IProductRepository
    {
        // TODO - Delete this product test dummy data later after database implementation.
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Product> GetAllProducts => new List<Product> {
            new Product { 
                ProductId = 1, 
                Name = "Сutlery set", 
                Price = 5.90M, 
                Description = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad " +
                "minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute " +
                "irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint " +
                "occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 
                Category = _categoryRepository.GetAllCategories.ToList()[0], 
                ImageUrl = "https://zerro.by/wp-content/uploads/2019/12/1_5.jpg",
                IsInStock = true, 
                IsOnSale = false, 
                ImageThumbnailUrl = "https://zerro.by/wp-content/uploads/2019/12/1_5.jpg"
            },
            new Product {
                ProductId = 2,
                Name = "Laundry soap",
                Price = 6.50M,
                Description = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad " +
                "minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute " +
                "irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint " +
                "occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl = "https://zerro.by/wp-content/uploads/2020/06/IMG_8639-scaled.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://zerro.by/wp-content/uploads/2020/06/IMG_8639-scaled.jpg"
            },
            new Product {
                ProductId = 3,
                Name = "Bag clip",
                Price = 10.99M,
                Description = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad " +
                "minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute " +
                "irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint " +
                "occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                Category = _categoryRepository.GetAllCategories.ToList()[2],
                ImageUrl = "https://zerro.by/wp-content/uploads/2020/04/276d6b755d4cf39e4922.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://zerro.by/wp-content/uploads/2020/04/276d6b755d4cf39e4922.jpg"
            }
        };

        public IEnumerable<Product> GetProductsOnSale => throw new NotImplementedException();

        public Product GetProductById(int productId)
        {
            return GetAllProducts.Where(x => x.ProductId == productId).First(); // TODO - Maybe replace with .FirstOrDefault() method.
        }
    }
}
