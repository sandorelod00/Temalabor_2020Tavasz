using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public UserService userService { get; }
        public UserManager<User> userManager { get; }
        public User user { get; set; }
        public bool userSignedin { get; set; }
        public bool alreadyAdded { get; set; }
        public string Message { get; set; }
        public int thisId { get; set; }
        public UserDetailModel(UserService _userService, UserManager<User> _userManager)
        {
            userService = _userService;
            userManager = _userManager;
        }

        public async Task<IActionResult> OnPostAddfriend(int? Id)
        {
            userSignedin = User.Identity.IsAuthenticated;
            if (userSignedin)
            {
                int myId = int.Parse(userManager.GetUserId(User));
                User currentUser = userService.getUserById(Id.Value);
                User me = userService.getUserById(myId);
                Friendship fs = new Friendship()
                {
                    User1Id = myId,
                    User2Id = Id.Value
                };
                if (!alreadyAdded)
                {
                    userService.DbContext.Friendship.Add(fs);
                    userService.DbContext.SaveChanges();
                }
                
                alreadyAdded = true;
                return Redirect("./UserDetail?Id=" + Id.ToString());
            }
            return Redirect("./UserDetail?Id=" + Id.ToString());
        }

        public void checkFriends( int? Id)
        {
            alreadyAdded = false;
            user = userService.getUserById(Id.Value);
            foreach (Friendship fs in userService.DbContext.Friendship)
            {
                if (fs!= null && user != null && userManager.GetUserId(User) != null)
                {
                    if (fs.User1Id == int.Parse(userManager.GetUserId(User)) && fs.User2Id == user.Id ||
                    fs.User2Id == int.Parse(userManager.GetUserId(User)) && fs.User1Id == user.Id)
                    {
                        alreadyAdded = true;
                        break;
                    }
                }
            }
        }

        public async Task<IActionResult> OnGet(int? Id)
        {
            userSignedin = User.Identity.IsAuthenticated;

            if (userSignedin)
            {
                checkFriends(Id);
                thisId = int.Parse(userManager.GetUserId(User));
            }

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