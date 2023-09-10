using NissinAPI.Domain;

namespace NissinAPI.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal NetPrice { get; set; }
        public ProductDTO(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            NetPrice = product.NetPrice;
            FullPrice = NetPrice * 1.23m;
        }
        public decimal FullPrice { get; } 
    }
}
