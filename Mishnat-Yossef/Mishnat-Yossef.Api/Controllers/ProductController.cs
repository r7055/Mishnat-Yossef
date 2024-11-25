using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mishnat_Yossef.Core.Entities;
using Mishnat_Yossef.Core.InterfaceService;

namespace Mishnat_Yossef.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var result = _productService.GetAll();
            if (result == null) return NotFound();
            return result;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(string id)
        {
            if (id == null) return BadRequest();
            var result = _productService.Get(id);
            if (result == null) return NotFound();
            return result;
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Product product)
        {
            if (product == null) return BadRequest();
            return _productService.Add(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id, [FromBody] Product product)
        {
            if (id == null) return BadRequest();
            return _productService.Update(id, product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteProduct(string id)
        {
            if (id == null) return BadRequest();
            return _productService.Delete(id);
        }
    }
}
