using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.DTO
{
    public class VillaCreateDTO
    {

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupancy { get; set; }
        public string? Place { get; set; }

        public string? Amenity { get; set; }
    }
}
