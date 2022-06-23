using BlazorEcommerce.Server.Data;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int id)
        {
            var result = await _context.Products.FindAsync(id);
            var response = new ServiceResponse<Product>();

            if (result == null)
            {
                response.Success = false;
                response.Message = "Le produit n'a pas été trouvé";
            }
            else
            {
                response.Data = result;
            }

            return response;
        }

    }
}
