using Microsoft.AspNetCore.Mvc;
using NissinAPI.DTOs;
using NissinAPI.Infrastructure;

namespace NissinAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        public DataService dataService { get; set; } = new DataService();
        [HttpGet]
        public ActionResult<IEnumerable<OrderDTO>> GetAll()
        {
            var orders4Response = dataService.orders;
            var response = new List<OrderDTO>();
            foreach (var order in orders4Response)
            {
                response.Add(new OrderDTO(order));
            }
            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public ActionResult<OrderDTO> Get(int id)
        {
            var order4Response = dataService.orders.FirstOrDefault(o => o.Id == id);
            if (order4Response is null) return NotFound();
            var response = new OrderDTO(order4Response);
            return Ok(response);
        }
    }
}
