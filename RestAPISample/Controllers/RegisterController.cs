using Microsoft.AspNetCore.Mvc;
using RestAPISample.Dto;
using RestAPISample.services;

namespace RestAPISample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        [Route("RegisterUser")]
        public IActionResult RegisterUser([FromBody] RegisterDto registerDto)
        {
            RegisterService registerService = new();

            var result = registerService.RegisterUser(registerDto.Name, registerDto.Age, registerDto.Email);

            return StatusCode(result._StatusCode, result._Message);
        }
    }
}