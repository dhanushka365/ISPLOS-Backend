using API.Controllers;
using API.Tests.Controllers.MockData;
using AutoFixture;
using AutoMapper;
using Castle.Core.Configuration;
using Core.Entities;
using Core.Interfaces;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace API.Tests.Controllers
{
    public class ProductsControllerTests
    {

        

        private readonly ProductsController _controller;
        private readonly Mock<IGenericRepository<Product>> _mockProductsRepo;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly Mock<ILogger<ProductsController>> _mockLogger; // Add this

        public ProductsControllerTests()
        {
            // Initialize your dependencies and the controller here
            _configuration = new Mock<IConfiguration>().Object; // Replace with a proper configuration setup
            _mockProductsRepo = new Mock<IGenericRepository<Product>>();
            _mapper = new Mock<IMapper>().Object; // Replace with a proper AutoMapper setup
            _mockLogger = new Mock<ILogger<ProductsController>>(); // Initialize the mock logger

            //_controller = new ProductsController( _mockProductsRepo.Object, _mapper, _mockLogger.Object);
        }

        [Fact]
        public async Task GetProducts_ShouldReturn200Status()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.99m, Description="ABC", PictureUrl="ABC", CreatedAt= DateTime.Now, UpdatedAt= DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Product 2", Price = 19.99m ,  Description="ABC", PictureUrl="ABC", CreatedAt= DateTime.Now, UpdatedAt= DateTime.Now },
                new Product {Id = Guid.NewGuid(), Name = "Product 3", Price = 5.99m, Description = "ABC", PictureUrl = "ABC", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
            };

            _mockProductsRepo.Setup(repo => repo.GetAllQueryable()).Returns(products.AsQueryable());

            // Act
            var result = await _controller.GetProducts();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okResult.StatusCode);
        }
    }
    }