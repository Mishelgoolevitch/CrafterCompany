using CrafterCompany.Domain;
using CrafterCompany.Domain.Entities;
using CrafterCompany.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CrafterCompany.Models.Components
{
    public class MenuViewComponentEquipment:ViewComponent
    {
        private readonly DataManager _dataManager;

        public MenuViewComponentEquipment(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            IEnumerable<Equipment> list = await _dataManager.Equipments.GetEquipmentsAsync();

            //Доменную сущность на клиенте использовать не рекомендуется, оборачиваем ее в DTO


            IEnumerable<EquipmentDTO> listDTO = HelperDTO.TransformEquipment(list);

            return await Task.FromResult((IViewComponentResult)View("Default", listDTO));
        }
    }
}
