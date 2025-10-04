using Microsoft.AspNetCore.Mvc;

namespace CrafterCompany.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
