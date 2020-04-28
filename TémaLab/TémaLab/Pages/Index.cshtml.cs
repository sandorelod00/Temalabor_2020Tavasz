using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TémaLab.Data.DTOs;
using TémaLab.Data.Services;

namespace TémaLab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private PostService _postService;

        public IEnumerable<PostDto> Posts;
        public string Message { get; private set; }
        public IndexModel(ILogger<IndexModel> logger, [FromServices] PostService postService) 
        {
            _logger = logger;
            _postService = postService;
        }

        public void OnGet()
        {
            Posts = _postService.GetPosts();


        }
    }
}
