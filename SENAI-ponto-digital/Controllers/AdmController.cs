using Microsoft.AspNetCore.Mvc;

namespace SENAI_ponto_digital.Controllers
{
    public class AdmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}