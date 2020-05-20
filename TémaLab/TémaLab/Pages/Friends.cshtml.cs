using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab
{
    public class FriendsModel : PageModel
    {
        public UserService userService { get; }
        public UserManager<User> userManager { get; }
        public System.Security.Claims.ClaimsPrincipal thisUser { get; set; }
        public List<User> Friends { get; set; }
        public FriendsModel(UserService _userService, UserManager<User> _userManager)
        {
            userService = _userService;
            userManager = _userManager;
        }
        public async Task<IActionResult> OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                Friends = new List<User>();
                List<Friendship> allFriendships = userService.DbContext.Friendship.ToList();
                thisUser = this.User;
                foreach (Friendship fs in allFriendships)
                {
                    if (fs.User1Id == int.Parse(userManager.GetUserId(thisUser)))
                    {
                        Friends.Add(userService.getUserById(fs.User2Id));
                    }
                    else if (fs.User2Id == int.Parse(userManager.GetUserId(thisUser)))
                    {
                        Friends.Add(userService.getUserById(fs.User1Id));
                    }
                }
            }
            return Page();
        }
    }
}