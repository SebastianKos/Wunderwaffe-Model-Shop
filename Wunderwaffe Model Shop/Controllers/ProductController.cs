using Microsoft.AspNetCore.Mvc;
using Wunderwaffe_Model_Shop.Service;

namespace Wunderwaffe_Model_Shop.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbContext context;

		public ProductController(ApplicationDbContext context)
        {
			this.context = context;
		}
        public IActionResult Index()
		{
			var products = context.Products.ToList();
			return View(products);
		}

        public IActionResult Create()
        {
            return View();
        }
    }
}
