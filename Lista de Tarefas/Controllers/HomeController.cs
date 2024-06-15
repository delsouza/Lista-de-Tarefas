using Lista_de_Tarefas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lista_de_Tarefas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
