using Microsoft.AspNetCore.Mvc;
using PROJETO_KANBAN.Models;

namespace PROJETO_KANBAN.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
