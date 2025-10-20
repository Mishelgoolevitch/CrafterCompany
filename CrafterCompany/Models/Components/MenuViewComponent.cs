using CrafterCompany.Domain;
using CrafterCompany.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using CrafterCompany.Infrastructure;
namespace CrafterCompany.Models.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly DataManager _dataManager;

        public MenuViewComponent(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IEnumerable<Service> list = await _dataManager.Services.GetServicesAsync();


            //Доменную сущность на клиенте использовать не рекомендуется, оборачиваем ее в DTO

            IEnumerable<ServiceDTO> listDTO = HelperDTO.TransformServices(list);


            return await Task.FromResult((IViewComponentResult)View("Default", listDTO));
        }
        public async Task<IViewComponentResult> InvokeAsync2()
        {
           
            IEnumerable<Equipment> list1 = await _dataManager.Equipments.GetEquipmentsAsync();

            //Доменную сущность на клиенте использовать не рекомендуется, оборачиваем ее в DTO

           
            IEnumerable<EquipmentDTO> list2DTO = HelperDTO.TransformEquipment(list1);

            return await Task.FromResult((IViewComponentResult)View("Default2", list2DTO));
        }
    }
}
