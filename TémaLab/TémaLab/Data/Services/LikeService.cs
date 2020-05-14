using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;

namespace TémaLab.Data.Services
{
    public class LikeService
    {
        public LikeService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<LikeDto> GetLikes() => DbContext.Likes
            .Include(l => l.User)
            .Include(l => l.Post)
            .Include(l => l.Comment)
                .Select(l => new LikeDto
                { 
                    Id = l.Id,
                    UserId = l.UserId,
                    User = l.User,
                    Post = l.Post,
                    PostId = l.PostId,
                    Comment = l.Comment,
                    CommentId = l.CommentId,
                    date = l.date
                });

        public void NewLike(Like like)
        {
            DbContext.Add(like);
            DbContext.SaveChanges();
        }

        internal void DeleteLikeByPostid(int postId, int userId)
        {
            Like like = DbContext.Likes.Single(l => l.PostId == postId);
            DeleteLike(like);
        }

        internal void DeleteLikeByComemntId(int commentId, int userId)
        {
            Like like = DbContext.Likes.Single(l => l.CommentId == commentId && l.UserId == userId);
            DeleteLike(like);
        }
    
        private void DeleteLike(Like like)
        {
            DbContext.Likes.Remove(like);
            DbContext.SaveChanges();
        }
    
    }
}
