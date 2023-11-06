using Microsoft.AspNetCore.Mvc;
using NetCoreCustomTagHelper_2.Models.ContextClasses;

namespace NetCoreCustomTagHelper_2.Controllers
{
    public class ProductController : Controller
    {
        NorthwindContext _db;
        public ProductController(NorthwindContext db)
        {
            _db = db;
        }
        public IActionResult GetProducts()
        {
            return View(_db.Products.ToList());
        }
    }
}
