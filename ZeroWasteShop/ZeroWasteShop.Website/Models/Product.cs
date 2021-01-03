using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroWasteShop.Website.Models
{
    public class Product
    {
        // TODO - Maybe I should create a constructor in this class.

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } // TODO - Maybe it is a good idea to change it to integer in the future.
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
