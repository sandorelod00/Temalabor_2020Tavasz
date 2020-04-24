using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class FriendshipService
    {
        public FriendshipService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<FriendshipDto> GetUsers() => DbContext.Friendship
            .Include(f => f.User)
                .Select(f => new FriendshipDto
                { 
                    User1 = f.User1,
                    User1Id = f.User1Id,
                    User2 = f.User2,
                    User2Id = f.User2Id
                });
    }
}
