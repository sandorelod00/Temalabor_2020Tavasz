using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.DTOs
{
    public class EventDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public DateTime date { get; set; }

        public string Content { get; set; }

        public ICollection<EventParticipation> eventParticipations { get; set; }
    }
}
