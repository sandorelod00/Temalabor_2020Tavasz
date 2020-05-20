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
    public class EditMyProfileModel : PageModel
    {
        public EditMyProfileModel([FromServices]UserManager<User> userManager, [FromServices] UserService userService)
        {
            _userService = userService;
        }

        public IEnumerable<string> Roles { get; private set; }
        private UserService _userService;
        public async Task OnGet([FromServices]UserManager<User> userManager)
        {
            user = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(user);

        }

        [BindProperty]
        public User user { get; private set; }

        public async Task<IActionResult> OnPostAsync([FromServices]UserManager<User> userManager)
        {
            user = await userManager.GetUserAsync(HttpContext.User);
            var introduction = Request.Form["Introduction"];
            user.Introduction = introduction;
            _userService.updatedUser(user);
            return Redirect("./Index");
        }

    }
}