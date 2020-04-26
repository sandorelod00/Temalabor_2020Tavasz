using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class ParticipationService
    {
        public ParticipationService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<ParticipationDto> GetParticipations() => DbContext.Participations
            .Include(p => p.User)
            .Include(p => p.Competition)
                .Select(p => new ParticipationDto
                { 
                    Id =p.Id,
                    UserId = p.UserId,
                    User = p.User,
                    CompetitionId = p.CompetitionId,
                    Competition = p.Competition,
                    date = p.date
                });
    }
}
