using CrafterCompany.Domain;
using CrafterCompany.Domain.Entities;
using CrafterCompany.Infrastructure;
using CrafterCompany.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrafterCompany.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly DataManager _dataManager;

        public EquipmentsController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Equipment> list = await _dataManager.Equipments.GetEquipmentsAsync();

            //Доменную сущность на клиенте использовать не рекомендуется, оборачиваем ее в DTO

            IEnumerable<EquipmentDTO> listDTO = HelperDTO.TransformEquipment(list);

            return View(listDTO);
        }

        public async Task<IActionResult> Show(int id)
        {
            Equipment? entity = await _dataManager.Equipments.GetEquipmentByIdAsync(id);

            //Услуги с данным ID не найдено, отвечаем кодом 404
            if (entity is null)
                return NotFound();

            //Доменную сущность на клиенте использовать не рекомендуется, оборачиваем ее в DTO

            EquipmentDTO entityDTO = HelperDTO.TransformEquipment(entity);

            return View(entityDTO);
        }
    }
}
