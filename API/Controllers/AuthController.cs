using API.Dtos;
using AutoMapper;
using Core.Entities.Identity;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenRepository tokenRepository;
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        private readonly IRoleRepository roleRepository;
        private readonly IMapper mapper;

        public AuthController(ITokenRepository tokenRepository, UserManager<User> userManager,IConfiguration configuration,IRoleRepository roleRepository,IMapper mapper)
        {
            this.tokenRepository = tokenRepository;
            this.userManager = userManager;
            this.configuration = configuration;
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] RequestLoginDTO requestLoginDTO)
        {
            var user  =await  userManager.FindByEmailAsync(requestLoginDTO.Email);
            if (user != null)
            {
                var check = await userManager.CheckPasswordAsync(user, requestLoginDTO.Password);
                if (check)
                {

                    var role = await roleRepository.GetByIdAsync(x => x.Id == user.RoleId);
                    if (role != null)
                    {
                        var AccessToken = tokenRepository.CreateJWTToken(user, role, int.Parse(configuration["Token:Access"]));
                        var RefreshToken = tokenRepository.CreateJWTToken(user, role, int.Parse(configuration["Token:Refresh"]));
                        var userDTO = mapper.Map<UserDTO>(user);

                        var response = new TokenDTO
                        {
                            AccessToken = AccessToken,
                            RefreshToken = RefreshToken,
                            User = userDTO
                        };

                      return Ok(response);
                    }
                }
               
            }


            return BadRequest("Incorrect Username or Password");

        }

     
    
    }
}
