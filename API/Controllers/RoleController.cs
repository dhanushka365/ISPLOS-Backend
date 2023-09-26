using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository roleRepository;

        public RoleController(IRoleRepository roleRepository,IMapper mapper)
        {
            this.roleRepository = roleRepository;
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
          var Roles =   await roleRepository.ListAllAsync();

           return Ok(Roles);

        }
    }
}
