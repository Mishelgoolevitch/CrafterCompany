using System.ComponentModel.DataAnnotations;

namespace CrafterCompany.Models
{
    public class EquipmentDTO
    {
       
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Description { get; set; }
        public string? PhotoFileName { get; set; }
        public string? Capabilities { get; set; }
    }
}
