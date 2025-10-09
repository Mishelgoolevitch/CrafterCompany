using CrafterCompany.Domain.Repositories.Abstract;

namespace CrafterCompany.Domain
{
    public class DataManager
    {
        public IServiceCategoriesRepository ServiceCategories { get; set; }
        public IServicesRepository Services { get; set; }
        public IEquipmentsRepository Equipments { get; set; }

        public DataManager(IServiceCategoriesRepository serviceCategoriesRepository, IServicesRepository servicesRepository, IEquipmentsRepository equipments)
        {
            ServiceCategories = serviceCategoriesRepository;
            Services = servicesRepository;
            Equipments = equipments;
        }
    }
}
