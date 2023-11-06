using Microsoft.AspNetCore.Mvc;

namespace NetCoreCustomTagHelper_2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult GetCategories()
        {
            return View();
        }
    }
}
