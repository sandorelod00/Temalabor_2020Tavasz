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
                //UserName = u.UserName,
                


            });
        }
    }
}
