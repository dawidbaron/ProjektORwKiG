using AutoMapper;
using BP.Helpers;
using BP.Models.ViewModels;
using BP.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BP.Controllers.User
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;
        public UserController(IUserService userService, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }
        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Register([FromBody] UserVM userVM)
        {

            var user = _mapper.Map<Models.User.User>(userVM);

            try
            {
                _userService.Register(user, userVM.Password);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("[action]")]
        public IActionResult Authenticate([FromBody] UserVM userVM)
        {
            var user = _userService.Authenticate(userVM.Email, userVM.Password);

            if (user == null)
            {
                return BadRequest("Wprowadź poprawnie e-mail lub hasło! ");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNo = user.PhoneNo,
                Token = tokenString
            });
        }
        [AllowAnonymous]
        [HttpGet("[action]/{userId}")]
        public IActionResult GetUserReservations(Guid userId)
        {
            try
            {
                var reservations = _userService.GetUserReservations(userId);
                return Ok(reservations);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}