using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IGenericRepository<Order> _ordersRepo;
        private readonly IGenericRepository<OrderItem> _orderItemsRepo;
        private readonly IGenericRepository<DeliveryMethod> _dmRepo;
        private readonly IGenericRepository<OrderStatus> _orderStatusRepo;
        private readonly IGenericRepository<ProductItemOrdered> _produtItemOrdered;
        private readonly ILogger<OrderController> _logger;

        public OrderController( IConfiguration configuration, IGenericRepository<Order> ordersRepo,
            IGenericRepository<OrderItem> orderItemsRepo, IGenericRepository<DeliveryMethod> dmRepo, 
            IGenericRepository<OrderStatus> orderStatusRepo, IGenericRepository<ProductItemOrdered> produtItemOrdered,
            IMapper mapper, ILogger<OrderController> logger)
        {
            _configuration = configuration;
            _ordersRepo = ordersRepo;
            _orderItemsRepo = orderItemsRepo;
            _dmRepo = dmRepo;
            _orderStatusRepo = orderStatusRepo;
            _produtItemOrdered = produtItemOrdered;
            _mapper = mapper;
            _logger = logger;

        }


        //[HttpGet("Orders")]
        //public async Task<ActionResult<IReadOnlyList<Order>>> GetProductBrands(
        //     [FromQuery] string search = null,
        //     [FromQuery] int page = 1,
        //     [FromQuery] int pageSize = 10)
        //{

        //    Expression<Func<Order, bool>> filter = null;
        //    if (!string.IsNullOrEmpty(search))
        //    {
        //        filter = order => order.BuyerEmail.Contains(search, StringComparison.OrdinalIgnoreCase);
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


    }
}
