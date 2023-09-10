namespace NissinAPI.Domain
{
    public class Order
    {
        
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public string Notes;
    }
}
