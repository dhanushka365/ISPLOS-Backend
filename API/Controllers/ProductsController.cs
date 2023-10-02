using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net.WebSockets;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
      //  private readonly IGenericRepository<Product> _productsRepo;
      //  private readonly IGenericRepository<Image> _imageRepository;

        private readonly IMapper _mapper;
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductRepository _productsRepo;
        private readonly IImageRepository imageRepository;

        public ProductsController(IConfiguration configuration,
          IMapper mapper, ILogger<ProductsController> logger,IProductRepository productsRepo,IImageRepository imageRepository)
        {
            _configuration = configuration;
            _logger = logger;
            _productsRepo = productsRepo;
            this.imageRepository = imageRepository;
            _mapper = mapper;
          //  _imageRepository = imageRepository;
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("admin/all")]
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult<List<Product>>> GetProducts([FromQuery] string Name)
        {

            var queryableProducts = _productsRepo.GetAllQueryable();
            var products = new List<ProductToReturnDto>();
            if (!string.IsNullOrEmpty(Name))
            {
                products  =  await queryableProducts.Where(x=>x.Name.Contains(Name)).Select(p => new ProductToReturnDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Description = p.Description,
                    PictureUrl = p.PictureUrl,
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt
                })
                .ToListAsync(); 
            }
            else
            {
                products = await queryableProducts
               .Select(p => new ProductToReturnDto
               {
                   Id = p.Id,
                   Name = p.Name,
                   Price = p.Price,
                   Description = p.Description,
                   PictureUrl = p.PictureUrl,
                   CreatedAt = p.CreatedAt,
                   UpdatedAt = p.UpdatedAt
               })
               .ToListAsync();

            }

            

            return Ok(products);

        }

        //-------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<ActionResult<Product>> GetProduct([FromRoute] Guid id)
        {

            var product = await _productsRepo.GetByIdAsync(product => product.Id == id);

            if (product == null)
            {
                return NotFound();
            }


            var productToReturn = new ProductToReturnDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                PictureUrl = product.PictureUrl
            };

            return Ok(productToReturn);
        }

        [HttpPut]
        [Route("Admin/{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateProduct(Guid id, RequestProductDto product)
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


            await _productsRepo.SaveAsync();

            return NoContent();
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]
        [Route("Admin")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddProduct([FromBody] RequestProductDto requestproductdto)
        {
            try
            {
                var ProductDomain = _mapper.Map<Product>(requestproductdto);
                var ProductID = Guid.NewGuid();
                ProductDomain.Id = ProductID;
                if (ProductDomain == null)
                {
                    NotFound();
                }
                await _productsRepo.AddAsync(ProductDomain);
                await _productsRepo.SaveAsync();
                var savedProductDto = _mapper.Map<ProductDto>(ProductDomain);
                _logger.LogInformation("Product added and saved successfully.");
                return CreatedAtAction(nameof(GetProduct), new { id = ProductDomain.Id }, savedProductDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding and saving the product.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpDelete]
        [Route("admin/{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            try
            {
                var Product = await _productsRepo.GetByIdAsync(product => product.Id == id);

                if (Product == null)
                {
                    NotFound();
                }

                _productsRepo.Delete(Product);
                await _productsRepo.SaveAsync();
                _logger.LogInformation("Product deleted successfully.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting the product.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        [Route("admin/upload/{productId}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UploadProductImage(Guid productId, [FromForm] ImageUploadRequestDto request)
        {
            var product = await _productsRepo.GetByIdAsync(p => p.Id == productId);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            ValidateFileUpload(request);


            if (!ModelState.IsValid)
            {
            
                return BadRequest(ModelState);
            }

            try
            {
                var imageEntity = new Image
                {
                    File = request.File,
                    FileName = request.FileName,
                    FileExtension = Path.GetExtension(request.FileName),
                    FileSizeInBytes = request.File.Length,
                    FileDescription = request.FileDescription,
                };

                var uploadedImage = await imageRepository.UploadImage(imageEntity);
                product.PictureUrl = uploadedImage.FilePath;
                await _productsRepo.UpdateAsync(product);

                return Ok("Image uploaded successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }

        private void ValidateFileUpload(ImageUploadRequestDto request)
        {
            var alloweExtentions = new string[] { ".jpg", ".jpeg", ".png" };


            if (!alloweExtentions.Contains(Path.GetExtension(path: request.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file type");
            }


            if (request.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "please upload file size more than 10mb");
            }

        }







    }

    //---------------------------------------------------------------------------------------------------------------------------------------------------

}
