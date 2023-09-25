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

        public ProductsController(IConfiguration configuration ,StoreContext context , IProductRepository repo)
        {
            _configuration = configuration;
            _context = context;
            _repo = repo;
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
            var products = await _repo.GetProductsAsync();
            return Ok(products);
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _repo.GetProductByIdAsync(id));
        }
    }
}
