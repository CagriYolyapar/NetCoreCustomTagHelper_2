using Microsoft.AspNetCore.Mvc;
using NetCoreCustomTagHelper_2.Models.Tools;

namespace NetCoreCustomTagHelper_2.Controllers
{
    public class EgitmenController : Controller
    {
        public IActionResult EgitmenEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EgitmenEkle(Egitmen model)
        {
            return RedirectToAction();
        }
    }
}
