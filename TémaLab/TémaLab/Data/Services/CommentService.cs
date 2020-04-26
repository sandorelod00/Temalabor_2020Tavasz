using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

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
    }
}
