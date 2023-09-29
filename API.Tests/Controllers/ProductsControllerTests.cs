using API.Controllers;
using AutoFixture;
using Core.Entities;
using Moq;

namespace API.Tests.Controllers
{
    public class ProductsControllerTests
    {

        private readonly IFixture _fixture;
        private readonly Mock<Product> _serviceMockProduct;
        private readonly ProductsController _productController;

        public ProductsControllerTests(IFixture fixture, Mock<Product> serviceMockProduct, ProductsController productController)
        {
            _fixture = fixture;
            _serviceMockProduct = serviceMockProduct;
            _productController = productController;
        }

        [Fact]
        public void Test1()
        {
            

        }
    
    }
}