using CrafterCompany.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrafterCompany.Controllers.Admin
{
    public partial class AdminController
    {
        public async Task<IActionResult> EquipmentsEdit(int id)
        {
            Equipment? entity = id == default ? new Equipment() : await _dataManager.Equipments.GetEquipmentByIdAsync(id);
            ViewBag.Services = await _dataManager.Services.GetServicesAsync();
            return View(entity);
        }

        [HttpPost]
        public async Task<IActionResult> EquipmentsEdit(Equipment entity, IFormFile? titleImageFile)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Services = await _dataManager.Services.GetServicesAsync();
                return View(entity);
            }


            if (titleImageFile != null)
            {
                entity.Photo = titleImageFile.FileName;
                await SaveImg(titleImageFile);
            }

            await _dataManager.Equipments.SaveEquipmentAsync(entity);
            _logger.LogInformation($"Добавлена/обновлена услуга с ID:{entity.Id}");
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EquipmentDelete(int id)
        {
            await _dataManager.Equipments.DeleteEquipmentAsync(id);
            _logger.LogInformation($"Удалена услуга с ID:{id}");
            return RedirectToAction("Index");
        }
    }
}
