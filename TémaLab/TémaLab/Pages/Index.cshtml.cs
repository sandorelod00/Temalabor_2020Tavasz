using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;
using TémaLab.Data.Services;

namespace TémaLab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private PostService _postService;
        private CommentService _commentService;
        private UserService _userService;
        public IEnumerable<UserDto> Users;
        public IEnumerable<CommentDto> Comments;
        public IEnumerable<PostDto> Posts;
        public User? User { get; private set; }
        public IEnumerable<string>? Roles { get; private set; }
        public string Message { get; private set; }
        
        public IndexModel(ILogger<IndexModel> logger, [FromServices] PostService postService, [FromServices] CommentService commentService, [FromServices] UserService userService) 
        {
            _logger = logger;
            _postService = postService;
            _commentService = commentService;
            _userService = userService;
            
        }

        public async Task OnGet([FromServices]UserManager<User> userManager)
        {
            Posts = _postService.GetPosts();
            Comments = _commentService.GetComments();
            Users = _userService.GetUsers();
            User = await userManager.GetUserAsync(HttpContext.User);
            if (User != null) { 
                Roles = await userManager.GetRolesAsync(User);
            }
        }


        public async Task<IActionResult> OnPostAdd([FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(User);
            var PostContent = Request.Form["NewPostContent"];
            if (PostContent != "")
            {
                System.Diagnostics.Debug.WriteLine(PostContent);
                System.Diagnostics.Debug.WriteLine(User.UserName);

                Post createPost = new Post()
                {
                    Content = PostContent,
                    UserId = User.Id,
                };
                _postService.AddNewPost(createPost);
                return RedirectToPage("./Index");
            }
            return RedirectToPage("./Index");

        }
        public IActionResult OnPostDeletePost(int DeletePostId)
        {
            _postService.DeletePost(DeletePostId);
            return RedirectToPage("/Index");
        }

        public async Task<IActionResult> OnPostCommentAsync([FromServices]UserManager<User> userManager, int PostNewCommentId)
        {
            //var post = _postService.GetPost(PostId);
            User = await userManager.GetUserAsync(HttpContext.User);
            var CommentContent = Request.Form["NewComment"];
            if (CommentContent != "")
            {
                Comment comment = new Comment()
                {
                    PostId = PostNewCommentId,
                    UserId = User.Id,
                    Content = CommentContent,
                };
                _commentService.AddNewComment(comment);
            }
            return RedirectToPage("./Index");
        }


    }
}
