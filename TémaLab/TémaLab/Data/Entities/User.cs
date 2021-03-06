﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class User : IdentityUser<int>
    {
        //public override int Id { get; set; }
        //public override string UserName { get; set; }
        //public override string Email { get; set; }
        public string Introduction { get; set; }
        public string MTGACode { get; set; }
        public bool Admin { get; set;}
        public int score { get; set; }
        public string rank { get; set; }
        public ICollection<Post> Posts{ get; set; }
        public ICollection<Friendship> Friendships1 { get; set; }
        public ICollection<Friendship> Friendships2 { get; set; }
        public ICollection<Competition> Competitions{ get; set; }
        public ICollection<Participation> Participations { get; set; }
        public ICollection<EventParticipation> EventParticipations { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
