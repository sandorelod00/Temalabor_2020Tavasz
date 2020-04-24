using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class CompetitionService
    {
        public CompetitionService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<CompetitionDto> GetUsers() => DbContext.Competitions
            .Include(c => c.User)
            .Include(c => c.Participations)
                .Select(c => new CompetitionDto
                { 
                    Id = c.Id,
                    Title = c.Title,
                    UserId = c.UserId,
                    User = c.User,
                    date = c.date,
                    Content = c.Content,
                    Participations = c.Participations
                });
    }
}
