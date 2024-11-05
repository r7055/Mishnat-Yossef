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
        private object result;
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            result = _orderService.GetOrders();
            if (result == null) return NotFound();
            return Ok(result);
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(string id)
        {
            result = _orderService.GetOrderById(id);
            if(result==null) result = NotFound();
            return Ok(result);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> AddOrder([FromBody] Order order)
        {
            return _orderService.AddOrder(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateOrder(string id, [FromBody] Order order)
        {
            return _orderService.UpdateOrderById(id, order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteOrder(string id)
        {
            return _orderService.DeleteOrder(id);
        }
    }
}
