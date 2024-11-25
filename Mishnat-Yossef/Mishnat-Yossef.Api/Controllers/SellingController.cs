using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceService;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellingController : ControllerBase
    {
        readonly ISellingService _sellingService;
        public SellingController(ISellingService sellingService)
        {
            _sellingService = sellingService;
        }
        [HttpGet]
        public ActionResult<List<Selling>> GetSellings()
        {
            var result = _sellingService.GetAll();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<SellingController>/5
        [HttpGet("{id}")]
        public ActionResult<Selling> GetSellingById(string sellingId)
        {
            if (sellingId == null) return BadRequest();
            var result = _sellingService.Get(sellingId);
            if (result == null) return NotFound();
            return result;
        }

        // POST api/<SellingController>
        [HttpPost]
        public ActionResult<bool> AddSelling([FromBody] Selling selling)
        {
            if (selling == null) return BadRequest();
            return _sellingService.Add(selling);
        }

        // PUT api/<SellingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> UpdateSelling(string sellingId, [FromBody] Selling selling)
        {
            if (sellingId ==null) return BadRequest();
            return _sellingService.Update(sellingId, selling);
        }

        // DELETE api/<SellingController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSelling(string sellingId)
        {
            if (sellingId == null) return BadRequest();
            return _sellingService.Delete(sellingId);
        }
    }
}
