using Microsoft.AspNetCore.Mvc;

namespace Projet_PharmaService.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }    
        public IActionResult Inscription()
        {
            return View();
        } 
   

    }
}
