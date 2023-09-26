using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(IConfiguration configuration, IGenericRepository<Product> productsRepo,
            IGenericRepository<ProductType> productTypeRepo, IGenericRepository<ProductBrand> productBrandRepo, IMapper mapper, ILogger<ProductsController> logger)
        {
            _configuration = configuration;
            _productsRepo = productsRepo;
            _productTypeRepo = productTypeRepo;
            _productBrandRepo = productBrandRepo;
            _logger = logger;
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

            //return Ok(await _productsRepo.GetByIdAsync(product => product.Id == id));
            var product = await _productsRepo.GetByIdAsync(product => product.Id == id);

            if (product == null)
            {
                return Content("Product not found");
            }

            var productJson = JsonConvert.SerializeObject(product);

            return Content(productJson, "application/json");
        }


        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {

            var brands = await _productsRepo.ListAllAsync();
            //return Ok(await _productBrandRepo.ListAllAsync());
            if (brands == null)
            {
                return Content("Brand not found");
            }

            var productJson = JsonConvert.SerializeObject(brands);

            return Content(productJson, "application/json");
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {

            return Ok(await _productTypeRepo.ListAllAsync());


        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            var Product = await _productsRepo.GetByIdAsync(product => product.Id == id);

            if (Product == null)
            {
                NotFound();
            }

            _productsRepo.Delete(Product);
            await _productsRepo.SaveAsync();
            //wait _productsRepo.DeleteByIdAsync(product => product.Id == id);
            return NoContent();
        }

        [HttpPut("{ProductBrandid}")]
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



        //---------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost("brand")]
        public async Task<ActionResult> AddProductBrand([FromBody] RequestProductBrandDto requestproductBranddto)
        {
            try
            {
                var BrandDomain = _mapper.Map<ProductBrand>(requestproductBranddto);
                var BrandID = Guid.NewGuid();
                BrandDomain.Id = BrandID;
                if (BrandDomain == null)
                {
                    NotFound();
                }
                await _productBrandRepo.AddAsync(BrandDomain);
                await _productBrandRepo.SaveAsync();
                var savedProductBrandDto = _mapper.Map<ProductBrandDto>(BrandDomain);
                _logger.LogInformation("Product brand added and saved successfully.");
                return CreatedAtAction(nameof(GetProductBrands), new { id = BrandDomain.Id }, savedProductBrandDto);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error occurred while adding and saving the product brand.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

        }



        [HttpPost("type")]
        public async Task<ActionResult> AddProductType([FromBody] RequestProductTypeDto requestproductTypedto)
        {

            try
            {
                var TypeDomain = _mapper.Map<ProductType>(requestproductTypedto);
                var TypeID = Guid.NewGuid();
                TypeDomain.Id = TypeID;
                if (TypeDomain == null)
                {
                    NotFound();
                }
                await _productTypeRepo.AddAsync(TypeDomain);
                await _productTypeRepo.SaveAsync();
                var savedProductTypeDto = _mapper.Map<ProductTypeDto>(TypeDomain);
                _logger.LogInformation("Product Type added and saved successfully.");
                return CreatedAtAction(nameof(GetProductTypes), new { id = TypeDomain.Id }, savedProductTypeDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding and saving the product Type.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

     //---------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpDelete("brand/{id}")]
        public async Task<ActionResult> DeleteProductBrand(Guid id)
        {
            try
            {
                var ProductBrand = await _productBrandRepo.GetByIdAsync(product => product.Id == id);

                if (ProductBrand == null)
                {
                    NotFound();
                }

                _productBrandRepo.Delete(ProductBrand);
                await _productBrandRepo.SaveAsync();
                _logger.LogInformation("Product brand deleted successfully.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting the product brand.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("type/{id}")]
        public async Task<ActionResult> DeleteProductType(Guid id)
        {
            try
            {
                var ProductType = await _productTypeRepo.GetByIdAsync(product => product.Id == id);

                if (ProductType == null)
                {
                    NotFound();
                }

                _productTypeRepo.Delete(ProductType);
                await _productTypeRepo.SaveAsync();
                _logger.LogInformation("Product type deleted successfully.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting the product type.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


    }

    //---------------------------------------------------------------------------------------------------------------------------------------------------


    
}
