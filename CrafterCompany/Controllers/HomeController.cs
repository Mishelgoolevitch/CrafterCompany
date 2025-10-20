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
            //var model = new NavigationViewModel
            //{
            //    Services = Services.GetAll(),
            //    Equipments = Equipments.GetAll()
            //};
            //return View(model);
            return View();

        }

        public IActionResult Contacts()
        {
            return View();
        }

    }
}
