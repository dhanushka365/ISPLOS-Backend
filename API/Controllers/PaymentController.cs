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
        [Authorize(Roles ="Admin,User")]
        public async Task<ActionResult> GetPaymentr()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);

            var user = await userRepository.FilterObject(x => x.UserName == UserName);
            var payment = await paymentRepository.GetAllByUser(x => x.UserId == user.Id);
            var result = mapper.Map<IEnumerable<PaymentHistoryDTO>>(payment);
            return Ok(result);

        }

        [HttpGet]
        [Route("admin/user/{uid:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetPaymentHistoryOfUser([FromRoute] Guid uid)
        {
            var payment = await paymentRepository.GetAllByUser(x => x.UserId == uid);
            var result  =  mapper.Map<IEnumerable<PaymentHistoryDTO>>(payment);
            return Ok(result);
        }

        [HttpGet]
        [Route("user/payment")]
        [Authorize(Roles = "Admin,User")]
        public async Task<ActionResult> GetPaymentDetails()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);

            var user = await userRepository.FilterObject(x => x.UserName == UserName);
            var uid = user.Id;

            var OrderProductList = await orderRepository.GetAllWithPayableAmount(x => x.Order.UserID.Equals(uid) &&  x.Order.IsPaid == false);
            var balance = await balanceRepository.FilterObject(x => x.UserId == uid);
            decimal TotalAmount = 0;
            decimal BalanceAmount = 0;
            foreach (var orderProduct in OrderProductList)
            {
                TotalAmount += orderProduct.Amount;
            }

            if (balance != null)
            {
                BalanceAmount = balance.RemainBalance;
            }


            var response = new
            {
               Total= decimal.Parse(TotalAmount.ToString("0.00")),
               balance =  BalanceAmount,
            };
            return Ok(response);
        }

        [HttpGet]
        [Route("admin/user/{uid:Guid}/payment")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetPaymentDetailsOfUser([FromRoute] Guid uid)
        {
            var OrderProductList = await orderRepository.GetAllWithPayableAmount(x => x.Order.UserID.Equals(uid)&& x.Order.IsPaid ==false);
            var balance = await balanceRepository.FilterObject(x => x.UserId == uid);
            decimal TotalAmount = 0;
            decimal BalanceAmount = 0;
            foreach (var orderProduct in OrderProductList)
            {
                TotalAmount += orderProduct.Amount;
            }

            if (balance != null)
            {
                BalanceAmount = balance.RemainBalance;
            }


            var response = new 
               {
                Total = decimal.Parse(TotalAmount.ToString("0.00")),
                balance = BalanceAmount,
            };
            return Ok(response);
        }




        [HttpPost]
        [Route("admin/user/{uid:Guid}")]
        public async Task<ActionResult> AddPayment([FromBody] RequestPaymentDTO requestPaymentDTO, [FromRoute] Guid uid)
        {

            if (requestPaymentDTO == null)
            {
                return BadRequest("Requested Details Not Sufficient");
            }

            var OrderProductList = await orderRepository.GetAllWithPayableAmount(x => x.Order.UserID==uid && x.Order.IsPaid == false);
            var balance = await balanceRepository.FilterObject(x => x.UserId == uid);
            var totalAmount = requestPaymentDTO.Amount;
            if(balance != null)
            {
                totalAmount += balance.RemainBalance;
            }
            var Response = new List<OrderDto>();

            foreach ( var orderProduct in OrderProductList )
            {
                if(orderProduct.Amount <totalAmount)
                {
                    var order = await orderRepository.GetByIdAsync(x => x.Id == orderProduct.Id);
                    order.IsPaid = true;
                    await orderRepository.SaveAsync();
                    Response.Add(mapper.Map<OrderDto>(orderProduct));
                    totalAmount -= orderProduct.Amount;
                }
            }

            if (balance == null)
            {
                var balanceObj = new Balance
                {
                    UserId = uid,
                    RemainBalance = (decimal)totalAmount,
                };
               await balanceRepository.AddAsync(balanceObj);
            }
            else
            {
                balance.RemainBalance = (decimal)totalAmount;
            }

            var PaymentDomain = new Payment
            {
                Amount = (decimal)requestPaymentDTO.Amount,
                UserId = uid,
            };

            await paymentRepository.AddAsync(PaymentDomain);

            await balanceRepository.SaveAsync();
            await paymentRepository.SaveAsync();

            return Ok(Response);

        }
        
    }
}
