using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class UserService
    {
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public IEnumerable<UserDto> GetUsers() => DbContext.Users
            .Include(b => b.Events)
            .Include(b => b.Friendships1)
            .Include(b => b.Friendships2)
            .Include(b => b.Events)
            .Include(b => b.Competitions)
            .Include(b => b.Participations)
            .Include(b => b.EventParticipations)
            .Include(b => b.Posts).ToList()
                .Select(u => new UserDto
            {
                Id = u.Id,
                UserName = u.UserName,
                Introduction = u.Introduction,
                Email = u.Email,
                MTGACode = u.MTGACode,
                Admin = u.Admin,
                Posts = u.Posts,
                Friendships1 = u.Friendships1,
                Friendships2 = u.Friendships2,
                Competitions = u.Competitions,
                Participations = u.Participations,
                EventParticipations = u.EventParticipations,
                Events = u.Events
            });
    }
}
