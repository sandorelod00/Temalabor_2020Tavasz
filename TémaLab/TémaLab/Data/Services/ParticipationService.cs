using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;
using TémaLab.Data.Entities;

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

        public IEnumerable<ParticipationDto> GetParticipationById(int? compId)
        {

            return GetParticipations().Where(p => p.CompetitionId == compId);
        }

        public void addParticipation(Participation par)
        {
            DbContext.Add(par);
            DbContext.SaveChanges();
        }

        internal void removeParticipation(int? comID, int? uId)
        {
              var par =  DbContext.Participations.Single(p => p.CompetitionId == comID && p.UserId == uId);
            DbContext.Participations.Remove(par);
            DbContext.SaveChanges();
        }
    }
}
