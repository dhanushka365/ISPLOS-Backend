using AutoMapper;
using Core.Entities;
using Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper mapper;

        public OrderController( IMapper mapper)
        {
            
            this.mapper = mapper;
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
