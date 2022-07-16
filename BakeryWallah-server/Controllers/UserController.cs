using BakeryWallah.Business.Services;
using BakeryWallah.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWallah.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(
            IUserService userService)
            :base()
        {
            _userService = userService;
        }
        #region get all users
        [HttpGet]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }
        #endregion
        #region add users
        [HttpPost]
        [ProducesResponseType(typeof(Users), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddUser(Users user)
        {
            return Ok(_userService.AddUser(user));
        }
        #endregion

        #region add usertypes
        [HttpPost]
        [Route("UserTypes")]
        [ProducesResponseType(typeof(UserTypes), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddUserTypes(UserTypes userType)
        {
            return Ok(_userService.AddUserTypes(userType));
        }
        #endregion

    }
}
