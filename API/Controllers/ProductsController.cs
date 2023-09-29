﻿using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Identity;
using Core.Interfaces;
using Infrastructure.Data;
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

        public ProductsController(IConfiguration configuration,
          IMapper mapper, ILogger<ProductsController> logger,IProductRepository productsRepo)
        {
            _configuration = configuration;
            _logger = logger;
            _productsRepo = productsRepo;
            _mapper = mapper;
          //  _imageRepository = imageRepository;
        }


        //-------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {

            var queryableProducts = _productsRepo.GetAllQueryable();


            var products = await queryableProducts
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

            return Ok(products);

        }

        //-------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        [Route("{id:Guid}")]
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




        //[HttpGet("brands")]
        //public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands(
        //      [FromQuery] string search = null, 
        //      [FromQuery] int page = 1,         
        //      [FromQuery] int pageSize = 10)
        //{
            
        //    Expression<Func<ProductBrand, bool>> filter = null;
        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        filter = brand => brand.Name.Contains(search, StringComparison.OrdinalIgnoreCase);
        //    }

           
        //    int skip = (page - 1) * pageSize;

            
        //    var brands = await _productBrandRepo.ListAllAsync(
        //        filter: filter,
        //        orderBy: null, 
        //        pageNumber: page,
        //        pageSize: pageSize);

        //    return Ok(brands);
        //    //return Ok(await _productBrandRepo.ListAllAsync());
        //}


        //[HttpGet("types")]
        //public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        //{

        //    return Ok(await _productTypeRepo.ListAllAsync());


        //}

        //[HttpPut("type/{id}")]
        //public async Task<ActionResult> UpdateProductType(Guid id, productTypeUpdateDto productTypeUpdateDto)
        //{
        //    var productTypeDomain = await _productTypeRepo.GetByIdAsync(product => product.Id == id);

        //    if (productTypeDomain == null)
        //    {
        //        NotFound();
        //    }

        //    productTypeDomain.Name = productTypeUpdateDto.Name;

        //    await _productTypeRepo.SaveAsync();

        //    return Ok();
        //}


        //[HttpPut("brands/{id}")]
        //public async Task<ActionResult> UpdateProductBrand(Guid id, ProductBrandUpdateDto productBrandUpdateDto)
        //{
        //    var productBrandDomain = await _productBrandRepo.GetByIdAsync(product => product.Id == id);

        //    if (productBrandDomain == null)
        //    {
        //        NotFound();
        //    }

        //    productBrandDomain.Name = productBrandUpdateDto.Name;
        //    productBrandDomain.Description = productBrandUpdateDto.Description;

        //    await _productBrandRepo.SaveAsync();


        //    return Ok(); 
        //}


        [HttpPut("{id}")]
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

        //[HttpPost("brand")]
        //public async Task<ActionResult> AddProductBrand([FromBody] RequestProductBrandDto requestproductBranddto)
        //{
        //    try
        //    {
        //        var BrandDomain = _mapper.Map<ProductBrand>(requestproductBranddto);
        //        var BrandID = Guid.NewGuid();
        //        BrandDomain.Id = BrandID;
        //        if (BrandDomain == null)
        //        {
        //            NotFound();
        //        }
        //        await _productBrandRepo.AddAsync(BrandDomain);
        //        await _productBrandRepo.SaveAsync();
        //        var savedProductBrandDto = _mapper.Map<ProductBrandDto>(BrandDomain);
        //        _logger.LogInformation("Product brand added and saved successfully.");
        //        return CreatedAtAction(nameof(GetProductBrands), new { id = BrandDomain.Id }, savedProductBrandDto);
        //    }
        //    catch (Exception ex)
        //    {

        //        _logger.LogError(ex, "Error occurred while adding and saving the product brand.");
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }

        //}



        //[HttpPost("type")]
        //public async Task<ActionResult> AddProductType([FromBody] RequestProductTypeDto requestproductTypedto)
        //{

        //    try
        //    {
        //        var TypeDomain = _mapper.Map<ProductType>(requestproductTypedto);
        //        var TypeID = Guid.NewGuid();
        //        TypeDomain.Id = TypeID;
        //        if (TypeDomain == null)
        //        {
        //            NotFound();
        //        }
        //        await _productTypeRepo.AddAsync(TypeDomain);
        //        await _productTypeRepo.SaveAsync();
        //        var savedProductTypeDto = _mapper.Map<ProductTypeDto>(TypeDomain);
        //        _logger.LogInformation("Product Type added and saved successfully.");
        //        return CreatedAtAction(nameof(GetProductTypes), new { id = TypeDomain.Id }, savedProductTypeDto);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while adding and saving the product Type.");
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}

        [HttpPost]
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

        //[HttpDelete("brand/{id}")]
        //public async Task<ActionResult> DeleteProductBrand(Guid id)
        //{
        //    try
        //    {
        //        var ProductBrand = await _productBrandRepo.GetByIdAsync(product => product.Id == id);

        //        if (ProductBrand == null)
        //        {
        //            NotFound();
        //        }

        //        _productBrandRepo.Delete(ProductBrand);
        //        await _productBrandRepo.SaveAsync();
        //        _logger.LogInformation("Product brand deleted successfully.");
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while deleting the product brand.");
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}





        //[HttpDelete("type/{id}")]
        //public async Task<ActionResult> DeleteProductType(Guid id)
        //{
        //    try
        //    {
        //        var ProductType = await _productTypeRepo.GetByIdAsync(product => product.Id == id);

        //        if (ProductType == null)
        //        {
        //            NotFound();
        //        }

        //        _productTypeRepo.Delete(ProductType);
        //        await _productTypeRepo.SaveAsync();
        //        _logger.LogInformation("Product type deleted successfully.");
        //        return NoContent();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while deleting the product type.");
        //        return StatusCode(500, $"Internal server error: {ex.Message}");
        //    }
        //}

        [HttpDelete("{id}")]
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


        [HttpPatch]
        [Route("Upload/{productId}")]
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

              //  var uploadedImage = await _imageRepository.UploadImage(imageEntity);
              //  product.PictureUrl = uploadedImage.FilePath;
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
