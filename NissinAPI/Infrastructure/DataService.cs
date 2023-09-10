using NissinAPI.Controllers;
using NissinAPI.Domain;
using NissinAPI.DTOs;

namespace NissinAPI.Infrastructure
{
    public class DataService
    {
        public List<Product> products = new List<Product> {
                new Product { Id = 1, Description = "Ą slave for everyone", Name = "Slave", NetPrice = 42.00m},
                new Product { Id = 2, Description = "Ą phone for everyone", Name = "Phone", NetPrice = 21.37m}
            };
        public List<Order> orders = new List<Order>
        {
            new Order { Id = 1, DateOfOrder = DateTime.Now, CustomerId = 1, Notes = "", Products =  new List<Product> {
                new Product { Id = 1, Description = "Ą slave for everyone", Name = "Slave", NetPrice = 42.00m},
                new Product { Id = 2, Description = "Ą phone for everyone", Name = "Phone", NetPrice = 21.37m}
            }},
            new Order { Id = 2, DateOfOrder = DateTime.Now, CustomerId = 2, Notes = "", Products =  new List<Product> {
                new Product { Id = 1, Description = "Ą slave for everyone", Name = "Slave", NetPrice = 42.00m},
                new Product { Id = 2, Description = "Ą phone for everyone", Name = "Phone", NetPrice = 21.37m}
            }},
            new Order { Id = 3, DateOfOrder = DateTime.Now, CustomerId = 1, Notes = "", Products =  new List<Product> {
                new Product { Id = 1, Description = "Ą slave for everyone", Name = "Slave", NetPrice = 42.00m},
                new Product { Id = 2, Description = "Ą phone for everyone", Name = "Phone", NetPrice = 21.37m}
            }}
        };
    }
}
