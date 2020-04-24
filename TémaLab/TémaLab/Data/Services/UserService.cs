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

        public IEnumerable<UserDto> GetBooks()
        {
            return DbContext.Users.Select(u => new UserDto
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
}
