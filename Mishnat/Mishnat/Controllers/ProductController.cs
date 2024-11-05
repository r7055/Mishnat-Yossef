using Microsoft.AspNetCore.Mvc;
using Mishnat.NewFolder;
using Mishnat.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mishnat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly ProductService _productService;
        private object result;
        // GET: api/<ProductController>
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            result = _productService.GetProducts();
            if (result == null) return NotFound();
            return Ok(result);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(string id)
        {
            result=_productService.GetProductById(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Product product)
        {
            return _productService.AddProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(string id, [FromBody] Product product)
        {
            return _productService.UpdateProductById(id, product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteProduct(string id)
        {
            return _productService.DeleteProduct(id);
        }
    }
}
