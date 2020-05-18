using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TémaLab.Data.Entities;
using Microsoft.AspNetCore.Identity;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;

namespace TémaLab
{
    [Authorize]
    public class MyProfileModel : PageModel
    {
        public User user { get; private set; }
        public IEnumerable<string> Roles { get; private set; }
        public IEnumerable<PostDto> Posts { get; private set; }
        private PostService _postService;
        private CommentService _commentService;
        private UserService _userService;
        private LikeService _likeService;
        public async Task OnGet([FromServices]UserManager<User> userManager, [FromServices] PostService postService, [FromServices] CommentService commentService, [FromServices] UserService userService, [FromServices] LikeService likeService)
        {
            user = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(user);
            _postService = postService;
            _likeService = likeService;
            _userService = userService;
            _commentService = commentService;
            Posts = _postService.GetPosts().Where(p => p.User == user);
            
        }
    }
}