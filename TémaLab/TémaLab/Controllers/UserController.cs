using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;
using TémaLab.Model;

namespace TémaLab.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        UserService userService { get; }
        UserManager<User> userManager { get; }

        public UserController(UserService _userService, UserManager<User> _userManager)
        {
            userService = _userService;
            userManager = _userManager;
        }
        private int? currentUserId;
        private int? viewedUserId { get; }

        private int? CurrentUserId => User.Identity.IsAuthenticated
            ? (currentUserId ?? (currentUserId = int.Parse(userManager.GetUserId(User))))
            : null;

        //[AllowAnonymus]
        public IActionResult Index(int? Id)
        {
            if (!Id.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }
            var viewedUser = userService.getUserById(Id.Value);

            var currentUser = userService.getUserById(currentUserId.Value);

            if (viewedUser == null)
            {
                return NotFound();
            }

            var model = new UserModel { viewedUser = viewedUser, currentUser = currentUser };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddFriend()
        {
            userService.addFriend(CurrentUserId.Value, viewedUserId.Value);
            return RedirectToAction("Index", "User", new { id = viewedUserId });
        }
    }
}