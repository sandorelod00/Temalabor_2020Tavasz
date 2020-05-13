using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;

namespace TémaLab.Data.Services
{
    public class CommentService
    {
        public CommentService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<CommentDto> GetComments() => DbContext.Comments
            .Include(c => c.User)
            .Include(c => c.Post)
                .Select(c => new CommentDto
                { 
                    Id = c.Id,
                    UserId = c.UserId,
                    User = c.User,
                    PostId = c.PostId,
                    Post = c.Post,
                    date = c.date,
                    Content = c.Content
                });


        public IEnumerable<CommentDto> GetCommentsByPostId(int postId)
        {
            IEnumerable<CommentDto> PostComments;
            PostComments = DbContext.Comments
            .Include(c => c.User)
            .Include(c => c.Post)
                .Select(c => new CommentDto
                {
                    Id = c.Id,
                    UserId = c.UserId,
                    User = c.User,
                    PostId = c.PostId,
                    Post = c.Post,
                    date = c.date,
                    Content = c.Content
                }).Where(c => c.PostId == postId);
            return PostComments;
        }

        internal void AddNewComment(Comment comment)
        {
            DbContext.Comments.Add(comment);
            DbContext.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            Comment comment = DbContext.Comments.Single(c => c.Id == id);
            DbContext.Comments.Remove(comment);
            DbContext.SaveChanges();
        }
    }
}
