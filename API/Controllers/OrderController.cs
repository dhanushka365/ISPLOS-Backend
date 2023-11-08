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
        //private readonly IConfiguration _configuration;
        private readonly IUserRepository userRepository;
        private readonly IOrderProductRepository orderProductRepository;
        private readonly IProductRepository productRepository;
        private readonly IOrderRepository orderRepository;
        private readonly StoreContext storeContext;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IConfiguration configuration,
            IMapper mapper, ILogger<OrderController> logger,IUserRepository userRepository,IOrderProductRepository orderProductRepository,IProductRepository productRepository,IOrderRepository orderRepository,StoreContext storeContext)
        {
          //  _configuration = configuration;
            _mapper = mapper;
            _logger = logger;
            this.userRepository = userRepository;
            this.orderProductRepository = orderProductRepository;
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
            this.storeContext = storeContext;
        }

        //Get All Orders
        //Get Today's Orders
        [HttpGet]
        [Route("admin/all")]
        //[Authorize(Roles ="Admin")]
        public async Task<ActionResult<List<Order>>> GetALLOrders([FromQuery] bool isToday)
        {
            try
            {
                var OrderProductList = new List<Order>();
                if (isToday)
                {
                    var Today = DateTime.Now.ToShortDateString();
                    OrderProductList = await orderRepository.GetAllByParams(x => x.OrderDate == Today && x.IsPaid==false);
                }
                else
                {
                    OrderProductList = await orderRepository.GetAll();

                }
                
                  var response = _mapper.Map<List<OrderProductObjectResponseDTO>>(OrderProductList);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //Get One Order By ID
        [HttpGet]
        [Route("{id:Guid}")]
        //[Authorize(Roles = "Admin,User")]
        public async Task<ActionResult> GetOrder([FromRoute] Guid id)
        {
            try
            {
                var OrderProductList = await orderRepository.FindById(x=>x.Id.Equals(id));
                var response = _mapper.Map<OrderProductObjectResponseDTO>(OrderProductList);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //Get All the order of the User
        //Get All Paid Orders of the User
        //Get All UnPaid Orders of rge User
        [HttpGet]
        [Route("user")]
        //[Authorize(Roles = "Admin,User")]
        public async Task<ActionResult> GetOrderofUser([FromQuery] bool isPaid, [FromQuery] bool isAll)
        {
            try
            {
                var OrderProductList = new List<Order>();
                var UserName = User.FindFirstValue(ClaimTypes.Name);

                var user = await userRepository.FilterObject(x => x.UserName == UserName);

                if (isAll)
                {
                    OrderProductList = await orderRepository.GetAllByParams(x => x.UserID.Equals(user.Id));
                }
                else if (!isAll)
                {
                    OrderProductList = await orderRepository.GetAllByParams(x => x.UserID.Equals(user.Id) && x.IsPaid == isPaid);

                }


                var response = _mapper.Map<List<OrderProductObjectResponseDTO>>(OrderProductList);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }

        //Get Orders By User
        //Get All Paid Orders of the User
        //Get All UnPaid Orders of rge User
        [HttpGet]
        [Route("admin/user/{uid:Guid}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetOrderByUser([FromRoute] Guid uid, [FromQuery] bool isPaid, [FromQuery] bool isAll)
        {
            try
            {
                var OrderProductList = new List<Order>();

                if(isAll)
                {
                    OrderProductList = await orderRepository.GetAllByParams(x => x.UserID.Equals(uid));
                }
                else if (!isAll)
                {
                    OrderProductList = await orderRepository.GetAllByParams(x => x.UserID.Equals(uid) && x.IsPaid == isPaid);

                }
                

                var response = _mapper.Map<List<OrderProductObjectResponseDTO>>(OrderProductList);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }

        
        //Get Today's Orders
        [HttpGet]
        [Route("admin/today/stat")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetAllTodayOrderStat()
        {
            try
            {
                var Today = DateTime.Now.ToShortDateString();
                var OrderProductList = await orderRepository.GetALLByProductAndCount();
                var response = _mapper.Map<List<ProductStatDTO>>(OrderProductList);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //Create Order
        [HttpPost]
        //[Authorize(Roles ="Admin,User")]
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
                        OrderDate = DateTime.Now.ToShortDateString(),
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
                            Quantity = item.Quantity,
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

        //Create Order To Specific User
        [HttpPost]
        [Route("admin/user/{uid}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> CreateOrderForUser([FromBody] RequestOrderDto requestOrderDto, [FromRoute] Guid uid)
        {
            using (var transaction = storeContext.Database.BeginTransaction())
                try
                {
                    if (requestOrderDto == null)
                    {
                        return BadRequest("Requested Details Not Sufficient");
                    }
                    var user = await userRepository.GetByIdAsync(x => x.Id == uid);

                    var order = new Order
                    {
                        CreatedAt = DateTime.Now,
                        OrderDate = DateTime.Now.ToShortDateString(),
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
                            Quantity = item.Quantity,
                            CurrentPrice = Product.Price,
                            CreatedAt = DateTime.Now

                        };

                        Result.Add(_mapper.Map<OrderProductResponseDTO>(OrderProduct));

                        await orderProductRepository.AddAsync(OrderProduct);
                        await orderProductRepository.SaveAsync();

                    }

                    await transaction.CommitAsync();



                    _logger.LogInformation("Order created and saved successfully.");
                    return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, Result);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    _logger.LogError(ex, "Error occurred while creating and saving the order.");
                    return StatusCode(500, $"Internal server error: {ex.Message}");
                }
        }

        //Update Products of the Order
        [HttpPut]
        [Route("{id:Guid}/Products/{pid:Guid}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> UpdateOrderProduct([FromBody] UpdateOrderProductDTO updateOrderProductDTO, [FromRoute] Guid id, [FromRoute] Guid pid)
        {

            try
            {
                var orderProduct = await orderProductRepository.GetByIdAsync(x => x.OrderId.Equals(id) && x.ProductId.Equals(pid));

                if (orderProduct == null)
                {
                    return NotFound(); // Return a 404 Not Found response
                }

                orderProduct.Quantity = updateOrderProductDTO.Quantity;

                await orderProductRepository.SaveAsync();

                var response = _mapper.Map<OrderProductDTO>(orderProduct);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

          
        }

        //Delete the Product of the Order
        [HttpDelete]
        [Route("{id:Guid}/Products/{pid:Guid}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> DeleteOrderProduct([FromRoute] Guid id, [FromRoute] Guid pid)
        {

            try
            {
                var orderProduct = await orderProductRepository.GetByIdAsync(x => x.OrderId.Equals(id) && x.ProductId.Equals(pid));

                if (orderProduct == null)
                {
                    return NotFound(); // Return a 404 Not Found response
                }

                orderProductRepository.Delete(orderProduct);

                await orderProductRepository.SaveAsync();

                return Ok(orderProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }


        }

        //Delete the Order by Order ID
        [HttpDelete]
        [Route("{id:Guid}")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid id)
        {
            var order = await orderRepository.GetByIdAsync(x => x.Id == id);

            if (order == null)
            {
                return NotFound(); // Return a 404 Not Found response
            }

            orderRepository.Delete(order);
            await orderRepository.SaveAsync();

            return Ok(_mapper.Map<OrderDto>(order));
        }

    }

}

