using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.SeedService
{
    public class SeedService : ISeedService
    {
        public IDictionary<string, User> Users { get; } = new []
        {
            new User()
            {
                Id = 1,
                UserName = "Kovács Péter",
                Introduction="Én vagyok a Peti",
                Email="peti@mail.hu",
                MTGACode="kód",
                Admin = true
            }
        }.ToDictionary(a => a.UserName);

        public IDictionary<string, Competition> Competitions { get; }

        public IDictionary<string, Comment> Comments { get; }

        public IDictionary<string, Event> Events { get; }

        public IDictionary<string, Post> Posts { get; }

        public IDictionary<string, Like> Likes { get; }

    }
}
