using NissinAPI.Domain;

namespace NissinAPI.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Notes;
        public List<ProductDTO> ProductList;
        public decimal FullPrice;
        public decimal NetPrice;
        public OrderDTO(Order Order) 
        {
            this.Id = Order.Id;
            this.FullPrice = 0.00m;
            this.NetPrice = 0.00m;
            this.CustomerId = Order.CustomerId;
            this.Notes = Order.Notes;
            this.ProductList = new List<ProductDTO>();
            foreach (var product in Order.Products)
            {
                this.ProductList.Add(new ProductDTO(product));
            }
            this.DateOfOrder = Order.DateOfOrder;
            foreach (var product in this.ProductList)
            {
                FullPrice += product.FullPrice;
                NetPrice += product.NetPrice;
            }
        }

    }
}
