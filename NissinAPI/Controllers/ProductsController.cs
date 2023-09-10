using Microsoft.AspNetCore.Mvc;
using NissinAPI.DTOs;
using NissinAPI.Infrastructure;
using NissinAPI.Domain;

namespace NissinAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        public DataService dataService { get; set; } = new DataService();
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAll([FromQuery] String? search)
        {
            var products4Response = dataService.products.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                products4Response = products4Response.Where(p => p.Name.Contains(search));
            }
            var response = new List<ProductDTO>();
            foreach (var product in products4Response)
            {
                response.Add(new ProductDTO (product));
            }
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public ActionResult<ProductDTO> Get(int id)
        {
            var product4Response = dataService.products.FirstOrDefault(p => p.Id == id);
            if (product4Response is null) return NotFound();
            var response = new ProductDTO(product4Response);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductToCreateDTO product)
        {
            var id = 1 + dataService.products.Max(p => p.Id);
            var newProduct = new Product { Id = id, Description = product.Description, Name = product.Name, NetPrice = product.NetPrice};
            dataService.products.Add(newProduct);
            var newProductDTO = new ProductDTO(newProduct);
            return CreatedAtAction(nameof(Get), new {id = newProductDTO.Id}, newProductDTO);
        }
    }
}
