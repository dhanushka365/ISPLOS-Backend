using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Infrastructure.Data;
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

        private readonly ILogger<OrderController> _logger;

        public OrderController(IConfiguration configuration, IGenericRepository<Order> ordersRepo,
            IGenericRepository<OrderItem> orderItemsRepo, IGenericRepository<DeliveryMethod> dmRepo,
            IMapper mapper, ILogger<OrderController> logger, IGenericRepository<OrderStatus> orderStatusRepo)
        {
            _configuration = configuration;
            _ordersRepo = ordersRepo;
            _orderItemsRepo = orderItemsRepo;
            _dmRepo = dmRepo;
            _mapper = mapper;
            _logger = logger;
            _orderStatusRepo = orderStatusRepo;
        }

        [HttpGet("api-key")]
        public IActionResult GetApiKey()
        {
            var apiKey = _configuration["ConnectionStrings:DefaultConnection"];
            return Ok(apiKey);
        }


        [HttpGet("Orders")]
        public async Task<ActionResult<IReadOnlyList<Order>>> GetOrders(
            [FromQuery] string search = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            Expression<Func<Order, bool>> filter = null;

            if (!string.IsNullOrEmpty(search))
            {

                filter = order => order.User.UserName.Contains(search, StringComparison.OrdinalIgnoreCase);
            }

            int skip = (page - 1) * pageSize;

            var orders = await _ordersRepo.ListAllAsync(
                filter: filter,
                orderBy: null,
                pageNumber: page,
                pageSize: pageSize);

            return Ok(orders);
        }

        [HttpPost("order")]
        public async Task<ActionResult> CreateOrder([FromBody] RequestOrderDto requestOrderDto)
        {
            try
            {
                
                var order = _mapper.Map<Order>(requestOrderDto);
                order.Id = Guid.NewGuid();

                if (order == null)
                {
                    return NotFound(); // Return a 404 Not Found response
                }

                await _ordersRepo.AddAsync(order);

 
                await _ordersRepo.SaveAsync();

                var createdOrderDto = _mapper.Map<OrderDto>(order);

                _logger.LogInformation("Order created and saved successfully.");

                return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, createdOrderDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating and saving the order.");
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("orderStatus")]
        public async Task<IActionResult> CreateOrderStatus([FromBody] RequestOrderStatusDto requestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderStatus = _mapper.Map<OrderStatus>(requestDto);

            await _orderStatusRepo.AddAsync(orderStatus);
            await _orderStatusRepo.SaveAsync();

            var orderStatusDto = _mapper.Map<OrderStatusDto>(orderStatus);

            return CreatedAtAction(nameof(GetOrderStatus), new { id = orderStatus.Id }, orderStatusDto);
        }



        [HttpGet("OrderStatus")]
        public async Task<ActionResult<IReadOnlyList<OrderStatusDto>>> GetOrderStatus(
           [FromQuery] string search = null,
           [FromQuery] int page = 1,
           [FromQuery] int pageSize = 10)
        {
            Expression<Func<OrderStatus, bool>> filter = null;

            if (!string.IsNullOrEmpty(search))
            {
                
                filter = orderStatus => orderStatus.Name.Contains(search, StringComparison.OrdinalIgnoreCase);
            }

            int skip = (page - 1) * pageSize;

            
            var orderStatuses = await _orderStatusRepo.ListAllAsync(
                filter: filter,
                orderBy: null,  // Add sorting logic here if needed
                pageNumber: page,
                pageSize: pageSize);

            
            var orderStatusDtos = _mapper.Map<IReadOnlyList<OrderStatusDto>>(orderStatuses);

            return Ok(orderStatusDtos);
        }

        [HttpGet("OrderStatus/{id:Guid}")]
        public async Task<ActionResult<OrderStatusDto>> GetOrderStatus([FromRoute] Guid id)
        {
            
            var orderStatus = await _orderStatusRepo.GetByIdAsync(x => x.Id == id);

            if (orderStatus == null)
            {
                return NotFound(); // Return a 404 Not Found response
            }

            var orderStatusDto = _mapper.Map<OrderStatusDto>(orderStatus);

            return Ok(orderStatusDto); 
        }


    }

}

