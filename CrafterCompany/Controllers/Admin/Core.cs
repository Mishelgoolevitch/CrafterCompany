﻿using CrafterCompany.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CrafterCompany.Controllers.Admin
{
    [Authorize(Roles ="admin")]
    public partial class AdminController : Controller
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<AdminController> _logger;
        public AdminController(DataManager dataManager, IWebHostEnvironment hostingEnvironment, ILogger<AdminController> logger)
        {
            _dataManager = dataManager;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.ServiceCategories = await _dataManager.ServiceCategories.GetServiceCategoriesAsync();
            ViewBag.Services = await _dataManager.Services.GetServicesAsync();
            ViewBag.Equipments = await _dataManager.Equipments.GetServicesAsync();

            return View();
        }

        //Сохраняем картинку в файловую систему
        public async Task<string> SaveImg(IFormFile img)
        {
            string path = Path.Combine(_hostingEnvironment.WebRootPath, "img/", img.FileName);
            await using FileStream stream = new FileStream(path, FileMode.Create);
            await img.CopyToAsync(stream);

            return path;
        }

        // Сохраняем картинку из редактора
        public async Task<string> SaveEditorImg()
        {
            IFormFile img = Request.Form.Files[0];
            await SaveImg(img);

            return JsonSerializer.Serialize(new { location = Path.Combine("/img/", img.FileName) });
        }

    }
}
