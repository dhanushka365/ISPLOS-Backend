using API.Dtos;
using AutoMapper;
using Core.Entities.Identity;
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
        private readonly IMapper mapper;

        public RoleController(IRoleRepository roleRepository, IMapper mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var Roles = await roleRepository.ListAllAsync();

            return Ok(mapper.Map<List<RoleDTO>>(Roles));

        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var Role = await roleRepository.GetByIdAsync(x => x.Id == id);

            if (Role == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<RoleDTO>(Role));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestRoleDTO requestRoleDTO)
        {

            var RoleDomain = mapper.Map<Role>(requestRoleDTO);

            var RoleID =  Guid.NewGuid();
            RoleDomain.Id = RoleID;
            RoleDomain.NormalizedName = RoleDomain.Name.ToUpper();
            RoleDomain.ConcurrencyStamp = RoleID.ToString();

            if (RoleDomain == null)
            {
                NotFound();
            }

            await roleRepository.AddAsync(RoleDomain);
            await roleRepository.SaveAsync();

            var RoleDTO = mapper.Map<RoleDTO>(RoleDomain);

            return CreatedAtAction(nameof(Get), new { id = RoleDomain.Id }, RoleDTO);

        }


        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Put([FromBody] RequestRoleDTO requestRoleDTO, [FromRoute] Guid id)
        {

            var RoleDomain = await roleRepository.GetByIdAsync(x => x.Id == id);

            if (RoleDomain == null || requestRoleDTO == null)
            {
                return NotFound();
            }

            RoleDomain.Name = requestRoleDTO.Name;
            RoleDomain.NormalizedName = requestRoleDTO.Name.ToUpper();

            await roleRepository.SaveAsync();
            
            return Ok(mapper.Map<RoleDTO>(RoleDomain));
        }


        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {

            var RoleDomain = await roleRepository.GetByIdAsync(x => x.Id == id);

            if (RoleDomain == null)
            {
                return NotFound();
            }

            roleRepository.Delete(RoleDomain);
            await roleRepository.SaveAsync();

            return Ok(mapper.Map<RoleDTO>(RoleDomain));
        }
    }
}
