using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Introduction { get; set; }
        public string Email { get; set; }
        public string MTGACode { get; set; }
        public bool Admin { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Friendship> Friendships1 { get; set; }
        public ICollection<Friendship> Friendships2 { get; set; }
        public ICollection<Competition> Competitions { get; set; }
        public ICollection<Participation> Participations { get; set; }
        public ICollection<EventParticipation> EventParticipations { get; set; }
        public ICollection<Event> Events{ get; set; }
    }
}
