using Microsoft.AspNetCore.Mvc;

namespace Projet_PharmaService.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
