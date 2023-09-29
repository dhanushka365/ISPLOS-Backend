using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;

namespace Integration.Tests
{
    [TestClass]
    public class APITests
    {
        private WebApplicationFactory<Program> _webAppFactory;
        private HttpClient _httpClient;
        private Mock<ITodoRepository> _dbContextMock;

        [TestMethod]
        public void GetAllTest()
        {
           
        }
    }
}