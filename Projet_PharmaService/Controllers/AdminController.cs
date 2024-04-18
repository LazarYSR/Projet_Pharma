using Microsoft.AspNetCore.Mvc;

namespace Projet_PharmaService.Controllers
{
    public class AdminController : Controller
    {
<<<<<<< HEAD
        public IActionResult Index()
        {
            return View();
        }    
        public IActionResult Inscription()
        {
            return View();
        } 
        public IActionResult Inscription()
        {
            return View();
        }
=======
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

>>>>>>> b72ab161e59453237fa514863de66e6dbedf3aac
    }
}
