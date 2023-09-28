using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
        private readonly IGenericRepository<OrderStatusType> _orderStatusTypeRepo;

        private readonly ILogger<OrderController> _logger;

        public OrderController(IConfiguration configuration, IGenericRepository<Order> ordersRepo,
            IGenericRepository<OrderItem> orderItemsRepo, IGenericRepository<DeliveryMethod> dmRepo,
            IMapper mapper, ILogger<OrderController> logger, IGenericRepository<OrderStatus> orderStatusRepo, IGenericRepository<OrderStatusType> orderStatusTypeRepo)
        {
            _configuration = configuration;
            _ordersRepo = ordersRepo;
            _orderItemsRepo = orderItemsRepo;
            _dmRepo = dmRepo;
            _mapper = mapper;
            _logger = logger;
            _orderStatusRepo = orderStatusRepo;
            _orderStatusTypeRepo = orderStatusTypeRepo;

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
            orderStatus.Id = Guid.NewGuid();
            await _orderStatusRepo.AddAsync(orderStatus);
            await _orderStatusRepo.SaveAsync();
            var orderStatusDto = _mapper.Map<OrderStatusDto>(orderStatus);

            return CreatedAtAction(nameof(GetOrderStatus), new { id = orderStatus.Id }, orderStatusDto);
        }


   
        [HttpPost("orderStatusTypes")]
        public async Task<IActionResult> CreateOrderStatusType([FromBody] RequestOrderStatusTypeDto orderStatusTypeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderStatusType = _mapper.Map<OrderStatusType>(orderStatusTypeDto);
            await _orderStatusTypeRepo.AddAsync(orderStatusType);
            await _orderStatusTypeRepo.SaveAsync();
            var createdDto = _mapper.Map<OrderStatusTypeDto>(orderStatusType);

            return CreatedAtAction(nameof(GetOrderStatusTypes), new { id = createdDto.Id }, createdDto);
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


        [HttpGet("OrderStatusTypes")]
        public async Task<ActionResult<IReadOnlyList<OrderStatusTypeDto>>> GetOrderStatusTypes(
            [FromQuery] string search = null,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string orderBy = "name",
            [FromQuery] bool desc = false)
        {
            Expression<Func<OrderStatusType, bool>> filter = null;

            if (!string.IsNullOrEmpty(search))
            {
                filter = orderStatusType => orderStatusType.Name.Contains(search, StringComparison.OrdinalIgnoreCase);
            }

            int skip = (page - 1) * pageSize;

            Expression<Func<OrderStatusType, object>> sortingExpression;

            if (string.Equals(orderBy, "name", StringComparison.OrdinalIgnoreCase))
            {
                sortingExpression = orderStatusType => orderStatusType.Name;
            }
            else
            {
                sortingExpression = orderStatusType => orderStatusType.Name;
            }

            IQueryable<OrderStatusType> orderedQuery;
            if (desc)
            {
                orderedQuery = _orderStatusTypeRepo.Query().OrderByDescending(sortingExpression);
            }
            else
            {
                orderedQuery = _orderStatusTypeRepo.Query().OrderBy(sortingExpression);
            }

            if (filter != null)
            {
                orderedQuery = orderedQuery.Where(filter);
            }

            var orderStatusTypes = await orderedQuery
                .Skip(skip)
                .Take(pageSize)
                .ToListAsync();

            var orderStatusTypeDtos = _mapper.Map<IReadOnlyList<OrderStatusTypeDto>>(orderStatusTypes);

            return Ok(orderStatusTypeDtos);
        }


    }

}

