using System.ComponentModel.DataAnnotations;

namespace CrafterCompany.Domain.Entities
{
    public class Equipment : EntityBase
    {
      
        [Display(Name = "Выберите услугу, к которой относится станочное оборудование")]
        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        [Display(Name = "Описание")]
        [MaxLength(100_000)]
        public string? Description { get; set; }
        public string? Model { get; set; }

        public string? Capabilities { get; set; }

        [Display(Name = "Титульная картинка")]
        [MaxLength(300)]
        public string? Photo { get; set; }
      
    }
}
