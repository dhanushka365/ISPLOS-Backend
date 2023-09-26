using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
       
        private readonly IMapper mapper;

        public PaymentController( IMapper mapper)
        {
            
            this.mapper = mapper;
        }
    }
}
