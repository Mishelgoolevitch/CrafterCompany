using CrafterCompany.Domain.Entities;
using CrafterCompany.Models;

namespace CrafterCompany.Infrastructure
{
    public class HelperDTO
    {
        public static ServiceDTO TransformService(Service entity)
        {
            ServiceDTO entityDTO = new ServiceDTO();
            entityDTO.Id = entity.Id;
            entityDTO.CategoryName = entity.ServiceCategory?.Title;
            entityDTO.Title = entity.Title;
            entityDTO.DescriptionShort = entity.DescriptionShort;
            entityDTO.Description = entity.Description;
            entityDTO.PhotoFileName = entity.Photo;
            entityDTO.Type = entity.Type.ToString();
            return entityDTO;
        }

        public static IEnumerable<ServiceDTO> TransformServices(IEnumerable<Service> entities)
        {
            List<ServiceDTO> entitiesDTO = new List<ServiceDTO>();
            foreach (Service entity in entities)
                entitiesDTO.Add(TransformService(entity));
            return entitiesDTO;
        }

        public static EquipmentDTO TransformEquipment(Equipment entity)
        {
            EquipmentDTO entityDTO = new EquipmentDTO();
            entityDTO.Id = entity.Id;
            entityDTO.Model=entity.Model;
            entityDTO.Description = entity.Description;
            entityDTO.PhotoFileName = entity.Photo;
            entityDTO.Capabilities = entity.Capabilities;
         
            return entityDTO;
        }

        public static IEnumerable<EquipmentDTO> TransformEquipment(IEnumerable<Equipment> entities)
        {
            List<EquipmentDTO> entitiesDTO = new List<EquipmentDTO>();
            foreach (Equipment entity in entities)
                entitiesDTO.Add(TransformEquipment(entity));
            return entitiesDTO;
        }
    }
}
