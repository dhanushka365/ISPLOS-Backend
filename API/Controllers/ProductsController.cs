using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

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
        private readonly IMapper _mapper;

        public ProductsController(IConfiguration configuration , IGenericRepository<Product> productsRepo,
            IGenericRepository<ProductType> productTypeRepo,IGenericRepository<ProductBrand> productBrandRepo, IMapper mapper)
        {
            _configuration = configuration;
            _productsRepo = productsRepo;
            _productTypeRepo = productTypeRepo;
            _productBrandRepo = productBrandRepo;
            _mapper = mapper;
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
             var Product =  await _productsRepo.GetByIdAsync(product => product.Id == id);

            if (Product == null)
            {
                NotFound();
            }

            _productsRepo.Delete(Product);
            await _productsRepo.SaveAsync();
           //wait _productsRepo.DeleteByIdAsync(product => product.Id == id);
            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductBrand(Guid id)
        {
            var ProductBrand = await _productBrandRepo.GetByIdAsync(product => product.Id == id);

            if (ProductBrand == null)
            {
                NotFound();
            }

            _productBrandRepo.Delete(ProductBrand);
            await _productBrandRepo.SaveAsync();
            //wait _productsRepo.DeleteByIdAsync(product => product.Id == id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProductBrand(Guid id, ProductBrand productBrand)
        {
            var ProductBrandDomain = await _productBrandRepo.GetByIdAsync(product => product.Id == id);

            if (ProductBrandDomain == null)
            {
                NotFound();
            }

            ProductBrandDomain.Name = productBrand.Name;

            await _productBrandRepo.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(Guid id, Product product)
        {
            var ProductDomain = await _productsRepo.GetByIdAsync(product => product.Id == id);

            if (ProductDomain == null)
            {
                NotFound();
            }

            ProductDomain.Name = product.Name;
            ProductDomain.Description = product.Description;
            ProductDomain.Price = product.Price;
            ProductDomain.PictureUrl = product.PictureUrl;
            ProductDomain.ProductBrandId = product.ProductBrandId;
            ProductDomain.ProductTypeId = product.ProductTypeId;


           await _productsRepo.SaveAsync();

           return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct(Product product)
        {
            
            await _productsRepo.AddAsync(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);

            
        }



    }
}
