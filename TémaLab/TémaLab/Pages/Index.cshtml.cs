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


        public IEnumerable<PostDto> Posts;
        public User User { get; private set; }
        public IEnumerable<string> Roles { get; private set; }
        public string Message { get; private set; }
        
        public IndexModel(ILogger<IndexModel> logger, [FromServices] PostService postService) 
        {
            _logger = logger;
            _postService = postService;

        }

        public async Task OnGet([FromServices]UserManager<User> userManager)
        {
            Posts = _postService.GetPosts();
            User = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(User);
        }


        public async Task<IActionResult> OnPostAsync([FromServices]UserManager<User> userManager)
        {
            User = await userManager.GetUserAsync(HttpContext.User);
            Roles = await userManager.GetRolesAsync(User);
            var PostContent = Request.Form["NewPostContent"];
            if (PostContent != "")
            {
                System.Diagnostics.Debug.WriteLine(PostContent);
                System.Diagnostics.Debug.WriteLine(User.UserName);

                Post createPost = new Post();
                createPost.UserId = User.Id;
                createPost.Content = PostContent;
                _postService.AddNewPost(createPost);
                return RedirectToPage("./Index");
            }
            return Page();
            
        }




    }
}
