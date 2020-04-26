using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.DTOs;

namespace TémaLab.Data.Services
{
    public class EventService
    {
        public EventService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<EventDto> GetEvents() => DbContext.Events
            .Include(e => e.User)
            .Include(e => e.eventParticipations)
                .Select(e => new EventDto
                { 
                    Id = e.Id,
                    Title = e.Title,
                    UserId = e.UserId,
                    User = e.User,
                    date = e.date,
                    Content = e.Content,
                    eventParticipations = e.eventParticipations
                });
    }
}
