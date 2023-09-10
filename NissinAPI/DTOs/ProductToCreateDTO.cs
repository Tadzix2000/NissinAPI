using System.ComponentModel.DataAnnotations;

namespace NissinAPI.DTOs
{
    public class ProductToCreateDTO
    {
        [Required]
        [MinLength(1)]
        [MaxLength(32)]
        public string Name { get; set; }
        
        [MinLength(1)]
        [MaxLength(512)]
        public string Description { get; set; }
        [Required]
        public decimal NetPrice { get; set; }
    }
}
