namespace CrafterCompany.Domain.Entities
{
    public class ServiceCategory : EntityBase
    {
        public ICollection<Service>? Services { get; set; }
        public ICollection<Equipment>? equipment { get; set; }
    }
}
