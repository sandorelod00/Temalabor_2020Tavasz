using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace TémaLab
{
    [Authorize]
    public class MyProfileModel : PageModel
    {
        public User user { get; private set; }
        public IEnumerable<string> Roles { get; private set; }
        public async Task OnGet([FromServices]UserManager<User> userManager)
        {
            user = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(user);

        }
    }
}