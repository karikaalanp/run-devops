using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_Client.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductContext.Products);
        }
    }
}
