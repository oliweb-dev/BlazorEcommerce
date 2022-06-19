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

        public async Task<ServiceResponse<List<Product>>> GetProductsAsyncs()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        //        public async Task<ServiceResponse<List<Product>>> Get(int id)
        //        {
        //            var result = await _context.Products.FindAsync(id);

        //            if (result != null)
        //            {
        //var response = new ServiceResponse<List<Product>>()
        //            {
        //                Data = result
        //            };
        //            }

        //        }

    }
}
