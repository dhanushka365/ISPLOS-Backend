using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
       
        private readonly IMapper mapper;
        private readonly IPaymentRepository paymentRepository;
        private readonly IBalanceRepository balanceRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IUserRepository userRepository;

        public PaymentController( IMapper mapper,IPaymentRepository paymentRepository ,IBalanceRepository balanceRepository,IOrderRepository orderRepository,IUserRepository userRepository)
        {
            
            this.mapper = mapper;
            this.paymentRepository = paymentRepository;
            this.balanceRepository = balanceRepository;
            this.orderRepository = orderRepository;
            this.userRepository = userRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> GetPaymentr()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);

            var user = await userRepository.FilterObject(x => x.UserName == UserName);
            var payment = await paymentRepository.FilterList(x => x.UserId == user.Id);
            return Ok(mapper.Map<List<PaymentDTO>>(payment));

        }

        [HttpGet]
        [Route("user/{uid:Guid}/payment")]
        public async Task<ActionResult> GetPaymentDetails([FromRoute] Guid uid)
        {
            var payment = await paymentRepository.FilterList(x => x.UserId == uid);
            return Ok(payment);
        }

        [HttpGet]
        [Route("user/{uid:Guid}")]
        public async Task<ActionResult> GetPaymentHistoryOfUser([FromRoute] Guid uid)
        {
            var OrderProductList = await orderRepository.GetAllWithPayableAmount(x => x.Order.UserID.Equals(uid));
            var balance = await balanceRepository.FilterObject(x => x.UserId == uid);
            decimal TotalAmount = 0;
            foreach (var orderProduct in OrderProductList)
            {
                TotalAmount += orderProduct.Amount;
            }

            var response = new 
               {
                   TotalAmount,
                  balance.RemainBalance,
                };
            return Ok(response);
        }




        [HttpPost]
        [Route("user/{uid:Guid}")]
        public async Task<ActionResult> AddPayment([FromBody] RequestPaymentDTO requestPaymentDTO, [FromRoute] Guid uid)
        {

            if (requestPaymentDTO == null)
            {
                return BadRequest("Requested Details Not Sufficient");
            }

            var OrderProductList = await orderRepository.GetAllWithPayableAmount(x => x.Order.UserID.Equals(uid) && x.Order.IsPaid == false);

            var Response = new List<OrderDto>();
            foreach ( var orderProduct in OrderProductList )
            {
                if(orderProduct.Amount < requestPaymentDTO.Amount)
                {
                    var order = await orderRepository.GetByIdAsync(x => x.Id == orderProduct.Id);
                    order.IsPaid = true;
                    await orderRepository.SaveAsync();
                    Response.Add(mapper.Map<OrderDto>(orderProduct));
                    requestPaymentDTO.Amount -= orderProduct.Amount;
                }
            }

            var balance =await balanceRepository.FilterObject(x=>x.UserId == uid);
            if (balance == null)
            {
                var balanceObj = new Balance
                {
                    UserId = uid,
                    RemainBalance = (decimal)requestPaymentDTO.Amount,
                };
               await balanceRepository.AddAsync(balanceObj);
            }
            else
            {
                balance.RemainBalance = (decimal)requestPaymentDTO.Amount;
            }

            await balanceRepository.SaveAsync();

            return Ok(Response);

        }
        
    }
}
