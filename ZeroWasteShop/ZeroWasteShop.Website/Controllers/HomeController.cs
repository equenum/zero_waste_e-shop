using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroWasteShop.Website.Models;
using ZeroWasteShop.Website.ViewModels;

namespace ZeroWasteShop.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.ProductsOnSale = _productRepository.GetProductsOnSale;

            return View(homeViewModel);
        }
    }
}
