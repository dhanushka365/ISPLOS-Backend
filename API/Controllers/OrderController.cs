using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IUserRepository userRepository;
        private readonly IOrderProductRepository orderProductRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderRepository orderRepository;
        private readonly StoreContext storeContext;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IConfiguration configuration,
            IMapper mapper, ILogger<OrderController> logger,IUserRepository userRepository,IOrderProductRepository orderProductRepository,IProductRepository productRepository,IOrderRepository orderRepository,StoreContext storeContext)
        {
            _configuration = configuration;
            _mapper = mapper;
            _logger = logger;
            this.userRepository = userRepository;
            this.orderProductRepository = orderProductRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
            this.storeContext = storeContext;
        }



        //[HttpGet]
        //public async Task<ActionResult<IReadOnlyList<Order>>> GetOrders(
        //    [FromQuery] string search = null,
        //    [FromQuery] int page = 1,
        //    [FromQuery] int pageSize = 10)
        //{
        //    Expression<Func<Order, bool>> filter = null;

        //    if (!string.IsNullOrEmpty(search))
        //    {

        //        filter = order => order.User.UserName.Contains(search, StringComparison.OrdinalIgnoreCase);
        //    }

        //    int skip = (page - 1) * pageSize;

        //    var orders = await orderRepository.ListAllAsync(
        //        filter: filter,
        //        orderBy: null,
        //        pageNumber: page,
        //        pageSize: pageSize);

        //    return Ok(orders);
        //}

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Order>>> GetALLOrders()
        {
            try
            {
                  var OrderProductList = await orderRepository.GetAll();
                  var response = _mapper.Map<List<OrderProductObjectResponseDTO>>(OrderProductList);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPost]
        [Authorize]
        public async Task<ActionResult> CreateOrder([FromBody] RequestOrderDto requestOrderDto)
        {
            using (var transaction = storeContext.Database.BeginTransaction())
                try
                {

                    if (requestOrderDto == null)
                    {
                        return BadRequest("Requested Details Not Sufficient");
                    }

                    var UserName = User.FindFirstValue(ClaimTypes.Name);

                    var user = await userRepository.FilterObject(x => x.UserName == UserName);

                    var order = new Order
                    {
                        CreatedAt = DateTime.Now,
                        OrderDate = DateTime.Now,
                        UserID = user.Id
                    };

                    await orderRepository.AddAsync(order);
                    await orderRepository.SaveAsync();

                    var Result = new List<OrderProductResponseDTO>();
                    foreach (var item in requestOrderDto.Order)
                    {
                        var Product = await productRepository.GetProductByIdAsync(item.ProductID);
                        var OrderProduct = new OrderProduct
                        {
                            Order = order,
                            Product = Product,
                            Quantity = item.Quntity,
                            CurrentPrice = Product.Price,
                            CreatedAt = DateTime.Now

                        };

                        Result.Add(_mapper.Map<OrderProductResponseDTO>(OrderProduct));
                        
                        await orderProductRepository.AddAsync(OrderProduct);
                        await orderProductRepository.SaveAsync();

                    }

                   await transaction.CommitAsync();
                   


                    _logger.LogInformation("Order created and saved successfully.");

                    return Ok(Result);

                    //  return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, createdOrderDto);
                }
                catch (Exception ex)
                {
                     await transaction.RollbackAsync();
                    _logger.LogError(ex, "Error occurred while creating and saving the order.");
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder([FromBody] OrderDto orderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = await orderRepository.GetByIdAsync(x => x.Id == orderDto.Id);

            if (order == null)
            {
                return NotFound(); // Return a 404 Not Found response
            }

            _mapper.Map(orderDto, order);

            await orderRepository.UpdateAsync(order);
            await orderRepository.SaveAsync();

            return NoContent();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid id)
        {
            var order = await orderRepository.GetByIdAsync(x => x.Id == id);

            if (order == null)
            {
                return NotFound(); // Return a 404 Not Found response
            }

            orderRepository.Delete(order);
            await orderRepository.SaveAsync();

            return NoContent();
        }

        
    }

}

