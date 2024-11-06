using Microsoft.AspNetCore.Mvc;
using Mishnat.DTO;
using Mishnat.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mishnat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly OrderService _orderService;
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var result = _orderService.GetOrders();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            if (id < 0) return BadRequest();
            var result = _orderService.GetOrderById(id);
            if(result==null) return NotFound();
            return result;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> AddOrder([FromBody] Order order)
        {
            if(order == null) return BadRequest();
            return _orderService.AddOrder(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateOrder(int id, [FromBody] Order order)
        {

            if(id < 0) return BadRequest();
            return _orderService.UpdateOrderById(id, order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteOrder(int id)
        {
            if (id < 0) return BadRequest();
            return _orderService.DeleteOrder(id);
        }
    }
}
