using Microsoft.AspNetCore.Mvc;

namespace Projet_PharmaService.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Principal()
        {
            return View("Principal");
        }
    }
}
