using Microsoft.AspNetCore.Mvc;

namespace RetroVideoGameStore.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: CategoriesController
        public IActionResult Index()
        {
            return View();
        }

    }
}
