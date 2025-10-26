using CrafterCompany.Domain;
using CrafterCompany.Domain.Entities;
using CrafterCompany.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrafterCompany.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();

        }

        public IActionResult Contacts()
        {
            return View();
        }

    }
}
