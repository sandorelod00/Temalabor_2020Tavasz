using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class EventParticipationService
    {
        public EventParticipationService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<EventParticipationDto> GetUsers() => DbContext.EventParticipations
            .Include(e => e.User)
            .Include(e => e.Event)
                .Select(e => new EventParticipationDto
                { 
                    Id = e.Id,
                    UserId = e.UserId,
                    User = e.User,
                    EventId = e.EventId,
                    Event = e.Event,
                    date = e.date
                });
    }
}
