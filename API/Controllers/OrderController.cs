using API.Dtos;
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

        [HttpGet("api-key")]
        public IActionResult GetApiKey()
        {
            var apiKey = _configuration["ConnectionStrings:DefaultConnection"];
            return Ok(apiKey);
        }

        [HttpGet("Orders")]
        public async Task<ActionResult<IReadOnlyList<Order>>> GetOrderBrands(
                        [FromQuery] string search = null,
                        [FromQuery] int page = 1,
                        [FromQuery] int pageSize = 10)
        {

            Expression<Func<Order, bool>> filter = null;
            if (!string.IsNullOrEmpty(search))
            {
                filter = order => order.BuyerEmail.Contains(search, StringComparison.OrdinalIgnoreCase);
            }
            int skip = (page - 1) * pageSize;

            var orders = await _ordersRepo.ListAllAsync(
                filter: filter,
                orderBy: null,
                pageNumber: page,
                pageSize: pageSize);

            return Ok(orders);

        }


        [HttpGet("DeliveryMethods")]
        public async Task<ActionResult<IReadOnlyList<DeliveryMethod>>> GetDeliveryMethods()
        {
            var deliveryMethods = await _dmRepo.ListAllAsync();
            return Ok(deliveryMethods);
        }

        [HttpGet("OrderStatus")]
        public async Task<ActionResult<IReadOnlyList<OrderStatus>>> GetOrderStatus()
        {
            var orderStatus = await _orderStatusRepo.ListAllAsync();
            return Ok(orderStatus);
        }

        [HttpGet("OrderItems")]
        public async Task<ActionResult<IReadOnlyList<OrderItem>>> GetOrderItems()
        {
            var orderItems = await _orderItemsRepo.ListAllAsync();
            return Ok(orderItems);
        }

        [HttpGet("ProductItemOrdered")]
        public async Task<ActionResult<IReadOnlyList<ProductItemOrdered>>> GetProductItemOrdered()
        {
            var productItemOrdered = await _produtItemOrdered.ListAllAsync();
            return Ok(productItemOrdered);
        }

        [HttpGet("OrderItems/{id}")]
        public async Task<ActionResult<IReadOnlyList<OrderItem>>> GetOrderItems(Guid id)
        {
            var orderItems = await _orderItemsRepo.ListAllAsync();
            return Ok(orderItems);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestOrderDto requestOrderDto)
        {

            var OrderDomain = _mapper.Map<Order>(requestOrderDto);

            var OrderID =  Guid.NewGuid();
            OrderDomain.Id = OrderID;
            OrderDomain.OrderDate = DateTimeOffset.Now;
            OrderDomain.DeliveryMethod = new DeliveryMethod { };
            OrderDomain.OrderItems = new List<OrderItem>();
            OrderDomain.Subtotal = 0;
            OrderDomain.Status = new OrderStatus { };
            OrderDomain.PaymentIntentId = OrderID.ToString();


            if (OrderDomain == null)
            {
                NotFound();
            }

            await _ordersRepo.AddAsync(OrderDomain);
            await _ordersRepo.SaveAsync();

            var OrderDTO = _mapper.Map<RequestOrderDto>(OrderDomain);

            return CreatedAtAction(nameof(GetOrderBrands), new { id = OrderDomain.Id }, OrderDTO);

        }


        [HttpPut("UpdateOrder/{id}")]
        public async Task<IActionResult> UpdateOrder([FromBody] RequestOrderDto requestOrderDto, [FromRoute] Guid id)
        {
            try
            {
                var OrderDomain = _mapper.Map<Order>(requestOrderDto);
                var OrderID = Guid.NewGuid();
                OrderDomain.Id = OrderID;
                if (OrderDomain == null)
                {
                    NotFound();
                }
                await _ordersRepo.UpdateAsync(OrderDomain);
                await _ordersRepo.SaveAsync();
                var savedOrderBrandDto = _mapper.Map<RequestOrderDto>(OrderDomain);
                _logger.LogInformation("Order updated and saved successfully.");
                return CreatedAtAction(nameof(GetOrderBrands), new { id = OrderDomain.Id }, savedOrderBrandDto);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Error occurred while updating the Order.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }




    }
}
