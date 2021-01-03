using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroWasteShop.Website.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Product> Products { get; set; }

        public Category(int categoryId, string categoryName, string categoryDescription)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
        }
    }
}
