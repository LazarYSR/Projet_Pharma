using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Projet_PharmaService.Data;
using Projet_PharmaService.Models;

namespace Projet_PharmaService.Controllers
{
    public class UserController : Controller
    {
       
        MyContext db;
        public UserController(MyContext db) 
        { 
            this.db = db; 
        }
        public IActionResult Principal()
        {
            return View("Principal");
        }
    }
}
