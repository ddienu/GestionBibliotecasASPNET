using Microsoft.AspNetCore.Mvc;

namespace GestionBibliotecasASPNET.Controllers
{
    public class SociosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
