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
        private readonly IGenericRepository<Product> _productsRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;
        private readonly IGenericRepository<ProductBrand> _productBrandRepo;

        public ProductsController(IConfiguration configuration , IGenericRepository<Product> productsRepo,
            IGenericRepository<ProductType> productTypeRepo,IGenericRepository<ProductBrand> productBrandRepo)
        {
            _configuration = configuration;
        
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
         
            var products = await _productsRepo.ListAllAsync();
            return Ok(products);
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
           
            return Ok(await _productsRepo.GetByIdAsync(product => product.Id == id));
        }


        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            
            return Ok(await _productBrandRepo.ListAllAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
           
            return Ok(await _productTypeRepo.ListAllAsync());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
         
            await _productsRepo.DeleteByIdAsync(product => product.Id == id);
            return NoContent();
        }

    }
}
