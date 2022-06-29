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
                Data = await _context.Products.Include(p => p.Variants).ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _context.Products
                                .Include(p => p.Variants)
                                .ThenInclude(v => v.ProductType)
                                .FirstOrDefaultAsync(p => p.Id == productId);

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

        public async Task<ServiceResponse<List<Product>>> GetProductByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                                .Where(p => p.Categorie.Url.ToLower().Equals(categoryUrl.ToLower()))
                                .Include(p => p.Variants)
                                .ToListAsync()
            };

            return response;
        }
    }
}
