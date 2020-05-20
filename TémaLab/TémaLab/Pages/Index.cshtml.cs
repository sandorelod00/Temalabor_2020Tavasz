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
        private LikeService _likeService;
        public IEnumerable<UserDto> Users;
        public IEnumerable<CommentDto> Comments;
        public IEnumerable<PostDto> Posts;
        public IEnumerable<LikeDto> Likes;
        public User? User { get; private set; }
        public IEnumerable<string>? Roles { get; private set; }
        public string Message { get; private set; }
        
        public IndexModel(ILogger<IndexModel> logger, [FromServices] PostService postService, [FromServices] CommentService commentService, [FromServices] UserService userService,[FromServices] LikeService likeService) 
        {
            _logger = logger;
            _postService = postService;
            _commentService = commentService;
            _userService = userService;
            _likeService = likeService;
        }

        public async Task OnGet([FromServices]UserManager<User> userManager)
        {
            Posts = _postService.GetPosts();
            Comments = _commentService.GetComments();
            Users = _userService.GetUsers();
            User = await userManager.GetUserAsync(HttpContext.User);
            Likes = _likeService.GetLikes();
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
        public IActionResult OnPostDeletePost(int PostId)
        {
            _postService.DeletePost(PostId);
            return RedirectToPage("/Index");
        }

        public async Task<IActionResult> OnPostCommentAsync([FromServices]UserManager<User> userManager, int PostId)
        {
            //var post = _postService.GetPost(PostId);
            User = await userManager.GetUserAsync(HttpContext.User);
            var CommentContent = Request.Form["NewComment"];
            if (CommentContent != "")
            {
                Comment comment = new Comment()
                {
                    PostId = PostId,
                    UserId = User.Id,
                    Content = CommentContent,
                };
                _commentService.AddNewComment(comment);
            }
            return RedirectToPage("./Index");
        }
        public IActionResult OnPostDeleteComment(int CommentId)
        {
            _commentService.DeleteComment(CommentId);
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostAddLikePostAsync([FromServices]UserManager<User> userManager, int postId)
        {

            User = await userManager.GetUserAsync(HttpContext.User);
            Like newLike = new Like()
            {
                UserId = User.Id,
                PostId = postId
            };
            _likeService.NewLike(newLike);
            return RedirectToPage("./Index");
        }

        public ActionResult OnPostLikeDeletePost(int postId, [FromServices]UserManager<User> userManager)
        {
            
            _likeService.DeleteLikeByPostid(postId, userManager.GetUserAsync(HttpContext.User).Id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnPostLikeDeleteComment(int commentId, [FromServices]UserManager<User> userManager)
        {
            _likeService.DeleteLikeByComemntId(commentId, userManager.GetUserAsync(HttpContext.User).Id);
            return RedirectToPage("./Index");
        }
        public async Task<IActionResult> OnPostAddLikeCommentAsync([FromServices]UserManager<User> userManager, int commentId)
        {

            User = await userManager.GetUserAsync(HttpContext.User);
            Like newLike = new Like()
            {
                UserId = User.Id,
                CommentId = commentId
            };
            _likeService.NewLike(newLike);
            return RedirectToPage("./Index");
        }

    }
}
