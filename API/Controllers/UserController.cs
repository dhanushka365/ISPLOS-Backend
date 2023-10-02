using API.Dtos;
using AutoMapper;
using Core.Entities.Identity;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public UserController(IUserRepository userRepository,IMapper mapper,UserManager<User> userManager)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        [Route("admin/all")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Get([FromQuery] string Name) {

            var userList = new List<User>();
            if (string.IsNullOrEmpty(Name))
            {
                 userList = await userRepository.ListAllAsync();
            }
            else
            {
                userList = await userRepository.FilterList(x=> x.Name.Contains(Name));
            }
            

            return Ok(mapper.Map<List<UserDTO>>(userList));
       
        }

        [HttpGet]
        [Route("admin/{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetUserByID([FromRoute] Guid id)
        {
            var user  =  await userRepository.GetByIdAsync(x=> x.Id == id);

            return Ok(mapper.Map<UserDTO>(user));

        }

        [HttpGet]
        [Authorize(Roles = "Admin,,User")]
        public async Task<IActionResult> Get()
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);
            var user = await userRepository.GetByIdAsync(x => x.UserName == UserName);

            return Ok(mapper.Map<UserDTO>(user));

        }


        [HttpPost]
        [Route("admin")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Post([FromBody] RequestUserDTO requestUserDTO)
        {
            var UserDomain = new User
            {
                Name = requestUserDTO.Name,
                Email = requestUserDTO.Email,
                UserName = requestUserDTO.Email,
                PhoneNumber = requestUserDTO.PhoneNumber,
                Avatar = requestUserDTO.Avatar,
                RoleId = requestUserDTO.RoleId
            };

            var IdentityResult  = await userManager.CreateAsync(UserDomain,requestUserDTO.Password);

            if(IdentityResult.Succeeded)
            {
                
                return Ok(mapper.Map<UserDTO>(UserDomain));
            }

            return BadRequest("Something Went wrong when Registering new user");

        }

        [HttpPut]
        [Route("Password")]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Put([FromBody] RequestUpdateUserPasswordDTO userPasswordDTO)
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);

            var UserDomain = await userRepository.GetByIdAsync(x => x.UserName == UserName);

            if (UserDomain == null)
            {
                return NotFound();
            }

            UserDomain.PasswordHash = userManager.PasswordHasher.HashPassword(UserDomain, userPasswordDTO.Password);

            var IdentityResult = await userManager.UpdateAsync(UserDomain);

            if (IdentityResult.Succeeded)
            {
                return Ok("The Password has been Updated!");
            }

            return BadRequest("Something Went wrong when Updating user.");

        }


        [HttpPut]
        [Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] RequestUpdateUser requestUserDTO)
        {
            var UserName = User.FindFirstValue(ClaimTypes.Name);
            var UserDomain  =  await userRepository.GetByIdAsync (x=> x.UserName == UserName);

           if(UserDomain == null)
            {
                return NotFound();
            }

            UserDomain.Name = requestUserDTO.Name;
            UserDomain.Email = requestUserDTO.Email;
            UserDomain.UserName = requestUserDTO.Email;
            UserDomain.PhoneNumber = requestUserDTO.PhoneNumber;
            UserDomain.Avatar = requestUserDTO.Avatar;
            UserDomain.RoleId = requestUserDTO.RoleId;

            var IdentityResult = await userManager.UpdateAsync(UserDomain);

            if(IdentityResult.Succeeded)
            {
                return Ok(mapper.Map<UserDTO>(UserDomain));
            }

            return BadRequest("Something Went wrong when Updating user.");

        }


        [HttpDelete]
        [Route("admin/{id:Guid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var UserDomain = await userRepository.GetByIdAsync(x => x.Id == id);

            if (UserDomain == null)
            {
                return NotFound();
            }

            var IdentityResult =   await userManager.DeleteAsync(UserDomain);
            if(IdentityResult.Succeeded)
            {
                return Ok(mapper.Map<UserDTO>(UserDomain));
            }

            return BadRequest("Something Went wrong when Updating user.");

        }
    }
}
