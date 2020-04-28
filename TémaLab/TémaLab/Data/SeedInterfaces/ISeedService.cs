using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.SeedInterfaces.SeedService
{
    public interface ISeedService
    {
        IDictionary<string, User> Users { get; }
        IDictionary<string, Competition> Competitions { get; }
        IDictionary<string, Comment> Comments { get; }
        IDictionary<string, Event> Events { get; }
        IDictionary<string, Post> Posts { get; }
        IDictionary<string, Like> Likes{ get; }
    }
}
