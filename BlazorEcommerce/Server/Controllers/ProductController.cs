using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
        new Product
        {
            Id = 1,
            Title = "SMARTPHONE XIAOMI REDMI 9AS BLUE",
            Description = "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?",
            ImageUrl = "https://www.vandenborre.be/WEB/images/products/300/xiaomi_redmi-9a-32gb-blue-2022_7923260_1.jpg",
            Price = 208.99m
        },
        new Product
        {
            Id = 2,
            Title = "SMARTPHONE XIAOMI REDMI 9A GREY",
            Description = "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?",
            ImageUrl = "https://www.vandenborre.be/WEB/images/products/300/xiaomi_xiaomi-redmi-9a-32gb-grey_8187630_1.jpg",
            Price = 214.99m
        },
        new Product
        {
            Id = 3,
            Title = "SMARTPHONE MOTOROLA MOTO E32 SLATE GREY",
            Description = "Le smartphone est devenu un objet indispensable car il nous permet de faire pleins de choses ! Mais quel système d’exploitation vous convient le mieux, vous prenez beaucoup de photos, vous regardez souvent des vidéos … ?",
            ImageUrl = "https://www.vandenborre.be/WEB/images/products/300/motorola_moto-e32-slate-grey_7914768_1.jpg",
            Price = 199.99m
        }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(products);
        }
    }
}
