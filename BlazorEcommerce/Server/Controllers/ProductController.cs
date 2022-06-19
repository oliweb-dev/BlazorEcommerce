using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var response = await _productService.GetProductsAsyncs();

            return Ok(response);
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<List<Product>>> Get(int id)
        //{
        //    var hero = await _context.SuperHeroes.FindAsync(id);
        //    if (hero == null)
        //    {
        //        return BadRequest("Hero not found.");
        //    }

        //    return Ok(hero);
        //}
    }
}
