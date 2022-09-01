using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Models;
using Shopping.Client.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Client.Controllers
{
    public class ProductController : Controller
    {
        private readonly IShoppingService _shoppingService;

        public ProductController(IShoppingService shoppingService)
        {
            _shoppingService = shoppingService ?? throw new ArgumentNullException(nameof(shoppingService));
        }

        public async Task<IActionResult> IndexAsync()
        {
            var productList = await _shoppingService.GetProducts();


            return View(productList);
            //return View(Enumerable.Range(1, 5).Select(index => new Product
            //{ 
            //    Name = "abc"
            //}).ToArray());
        }
    }
}
