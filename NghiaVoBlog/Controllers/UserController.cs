using Microsoft.AspNetCore.Mvc;
using NghiaVoBlog.Data;
using NghiaVoBlog.Dto.User;
using NghiaVoBlog.Models;
using NghiaVoBlog.Repository;

namespace NghiaVoBlog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public IActionResult AddUser(CreateUserDto CreateUserDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    DisplayName = CreateUserDto.DisplayName,
                    Email = CreateUserDto.Email,
                    Phone = CreateUserDto.Phone,
                    Address = CreateUserDto.Address,
                    DateOfBirth = CreateUserDto.DateOfBirth
                };
                var createUser = _userRepository.InsertUser(user);
                return Ok(createUser);

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetListUser()
        {
            var listUser = await _userRepository.GetListUser();
            return Ok(listUser);
        }

        [HttpPut]
        public IActionResult PutUser(Guid Id, PutUserDto PutUserDto)
        {
            if (ModelState.IsValid)
            {
                var userNew = new User()
                {
                    DisplayName = PutUserDto.DisplayName,
                    Email = PutUserDto.Email,
                    Phone = PutUserDto.Phone,
                    Address = PutUserDto.Address,
                    DateOfBirth = PutUserDto.DateOfBirth
                };
                return Ok(_userRepository.EditUser(Id, userNew));

            }
            else
            {
                return BadRequest(ModelState.ErrorCount);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUser(Guid id)
        {
            return Ok(_userRepository.DeleteUser(id));
        }


    }
}