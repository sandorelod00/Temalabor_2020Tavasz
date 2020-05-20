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
        public string Message { get; set; }
        public int thisId { get; set; }
        public UserDetailModel(UserService _userService, UserManager<User> _userManager)
        {
            userService = _userService;
            userManager = _userManager;
        }

        public async Task<IActionResult> OnPostAddfriend(int? Id)
        {
            int myId = int.Parse(userManager.GetUserId(User));
            User currentUser = userService.getUserById(Id.Value);
            User me = userService.getUserById(myId);
            Friendship fs = new Friendship()
            {
                User1Id = myId,
                //User1 = me,
                User2Id = Id.Value,
                //User2 = currentUser
            };
            userService.DbContext.Friendship.Add(fs);
            userService.DbContext.SaveChanges();
            //"Users/UserDetail?id=3"
            //me.Friendships1.Add(fs);
            //currentUser.Friendships1.Add(fs);
            //userService.getUserById(currentId).Friendships1.Add(new Friendship { User1Id = currentId, User1 = userService.getUserById(currentId), User2Id = user.Id , User2 = userService.getUserById(user.Id) });
            //user.Friendships1.Add(new Friendship { User2Id = currentId, User2 = userService.getUserById(currentId), User1Id = user.Id, User1 = userService.getUserById(user.Id) });
            return Redirect("./UserDetail?Id=" + Id.ToString());
        }

        public async Task<IActionResult> OnGet(int? Id)
        {
            thisId = int.Parse(userManager.GetUserId(User));

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