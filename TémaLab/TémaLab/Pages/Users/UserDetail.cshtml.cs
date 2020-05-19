using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class UserDetailModel : PageModel
    {
        UserService userService { get; }
        UserManager<User> userManager { get; }
        public User user { get; set; }
        public UserDetailModel(UserService _userService, UserManager<User> _userManager)
        {
            userService = _userService;
            userManager = _userManager;
        }

        public async Task<IActionResult> OnGet(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            user = userService.getUserById(Id.Value);
            if (user == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}