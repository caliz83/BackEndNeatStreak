using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndNeatStreak.Models.DTO;
using BackEndNeatStreak.Models;
using BackEndNeatStreak.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEndNeatStreak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;

        //constructor
        public UserController(UserService dataFromService) {
            _data = dataFromService;
        }

        //add a user
        [HttpGet("AddUser")]
        public bool AddUser(CreateAccountDTO UserToAdd) {
            return _data.AddUser(UserToAdd); 
        }

        //login
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDTO User) {
            return _data.Login(User); 
        }

        //delete user
        [HttpPost("DeleteUser/{UserToDelete}")]
        public bool DeleteUser(string UserToDelete){
            return _data.DeleteUser(UserToDelete); 
        }
    }
}