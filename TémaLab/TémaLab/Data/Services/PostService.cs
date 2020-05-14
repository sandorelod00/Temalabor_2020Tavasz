using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;

namespace TémaLab.Data.Services
{
    public class PostService
    {
        private CommentService _commetService;
        public PostService(ApplicationDbContext dbContext,CommentService commentService)
        {
            DbContext = dbContext;
            _commetService = commentService;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<PostDto> GetPosts() => DbContext.Posts
            .Include(p => p.User)
            .Include(p => p.Comments)
            .Include(p => p.Likes)
                .Select(p => new PostDto
                {
                    Id = p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    date = p.date,
                    Content = p.Content,
                    Comments = p.Comments,
                    Likes = p.Likes

                }).OrderByDescending(p => p.Id);
            
        internal void AddNewPost(Post post)
        {
            //post.date = DateTime.Now();
            DbContext.Posts.Add(post);
            DbContext.SaveChanges();
        }

        internal void DeletePost(int id)
        {
            Post PostDelete = GetPost(id);
            List<Comment> comments = DbContext.Comments.Where(c => c.PostId == id).ToList();
            comments.ForEach(c => _commetService.DeleteComment(c.Id));
            DbContext.Posts.Remove(PostDelete);
            DbContext.SaveChanges();
        }

        internal Post GetPost(int id)
        {
            return DbContext.Posts.Single(p => p.Id == id);
        } 

    }
}
