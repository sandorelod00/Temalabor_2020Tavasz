using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class LeaderBoardModel : PageModel
    {
        public IEnumerable<UserDto> Users;
        private UserService _userService;
        public void OnGet([FromServices] UserService userService)
        {
            Users = userService.GetUsers();
            Users = Users.OrderByDescending(u => u.score);
        }
    }
}