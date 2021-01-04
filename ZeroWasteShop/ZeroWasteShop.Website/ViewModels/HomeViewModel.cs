using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroWasteShop.Website.Models;

namespace ZeroWasteShop.Website.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOnSale { get; set; }
    }
}
