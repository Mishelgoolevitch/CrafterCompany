using CrafterCompany.Models;

namespace CrafterCompany.Domain
{
    public class NavigationViewModel
    {
        public IEnumerable<ServiceDTO>? Services { get; set; }
        public IEnumerable<EquipmentDTO>? Equipments { get; set; }
    }
}
