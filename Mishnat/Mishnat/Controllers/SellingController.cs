using Microsoft.AspNetCore.Mvc;
using Mishnat.DTO;
using Mishnat.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mishnat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellingController : ControllerBase
    {
        readonly SellingService _sellingService= new  SellingService();
        // GET: api/<SellingController>
        [HttpGet]
        public ActionResult<List<Selling>> GetSellings()
        {
           var result = _sellingService.GetSellings();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<SellingController>/5
        [HttpGet("{id}")]
        public ActionResult<Selling> GetSellingById(int sellingId)
        {
            if (sellingId < 0) return BadRequest();
            var result = _sellingService.GetSellingById(sellingId);
            if(result==null) return NotFound();
            return result;
        }

        // POST api/<SellingController>
        [HttpPost]
        public ActionResult<bool> AddSelling([FromBody] Selling selling)
        {
            return _sellingService.AddSelling(selling);
        }

        // PUT api/<SellingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateSelling(int sellingId, [FromBody] Selling selling)
        {
            if (sellingId < 0) return BadRequest();

            return _sellingService.UpdateSellingById(sellingId,selling);
        }

        // DELETE api/<SellingController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSelling(int sellingId)
        {
            if (sellingId < 0)
                return BadRequest();
            return _sellingService.DeleteSelling(sellingId);
        }
    }
}
