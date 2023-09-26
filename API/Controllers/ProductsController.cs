using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly StoreContext _context;
        private readonly IProductRepository _repo;
        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandRepo;

        public ProductsController(IConfiguration configuration ,StoreContext context , IProductRepository repo, IGenericRepository<Product> productsRepo,
            IGenericRepository<ProductType> productTypeRepo,IGenericRepository<ProductBrand> productBrandRepo)
        {
            _configuration = configuration;
            _context = context;
            _repo = repo;
            _productsRepo = productsRepo;
            _productTypeRepo = productTypeRepo;
            _productBrandRepo = productBrandRepo;
        }

        [HttpGet("api-key")]
        public IActionResult GetApiKey()
        {
            var apiKey = _configuration["ConnectionStrings:DefaultConnection"];
            return Ok(apiKey);
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            //var products = await _context.Products.ToListAsync();
            //var products = await _repo.GetProductsAsync();
            var products = await _productsRepo.ListAllAsync();
            return Ok(products);
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            //return await _context.Products.FindAsync(id);
            //return Ok(await _repo.GetProductByIdAsync(id));
            return Ok(await _productsRepo.GetByIdAsync(id));
        }


        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            //return Ok(await _context.ProductBrands.ToListAsync());
            //return Ok( await _repo.GetProductBrandsAsync());
            return Ok(await _productBrandRepo.ListAllAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            //return Ok (await _context.ProductTypes.ToListAsync());
            //return Ok(await _repo.GetProductTypesAsync());
            return Ok(await _productTypeRepo.ListAllAsync());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            //var product = await _context.Products.FindAsync(id);
            //if (product == null) return NotFound();
            //_context.Products.Remove(product);
            //await _context.SaveChangesAsync();
            //return NoContent();
            await _productsRepo.DeleteByIdAsync(id);
            return NoContent();
        }

    }
}
