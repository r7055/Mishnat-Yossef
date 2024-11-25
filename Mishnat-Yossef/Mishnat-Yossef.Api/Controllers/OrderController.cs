using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceService;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            var result = _orderService.GetAll();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(string id)
        {
            if (id == null) return BadRequest();
            var result = _orderService.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> AddOrder([FromBody] Order order)
        {
            if (order == null) return BadRequest();
            return _orderService.Add(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateOrder(string id, [FromBody] Order order)
        {
            if (id == null) return BadRequest();
            bool res = _orderService.Update(id, order);
            if (!res) return NotFound(false);
            return true;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteOrder(string id)
        {
            if (id == null) return BadRequest();
            bool res = _orderService.Delete(id);
            if (res == false) return NotFound(false);
            return true;
        }
    }
}
