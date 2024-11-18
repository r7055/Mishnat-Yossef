using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly OrderService _orderService = new OrderService();
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
            if (result == null) return NotFound();
            return result;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> AddOrder([FromBody] Order order)
        {
            if (order == null) return BadRequest();
            return _orderService.AddOrder(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateOrder(int id, [FromBody] Order order)
        {
            if (id < 0) return BadRequest();
            bool res = _orderService.UpdateOrderById(id, order);
            if (!res) return NotFound(false);
            return true;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteOrder(int id)
        {
            if (id < 0) return BadRequest();
            bool res = _orderService.DeleteOrder(id);
            if (res == false) return NotFound(false);
            return true;
        }
    }
}
