using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.SeedInterfaces.SeedService
{
    public interface ISeedService
    {
        IList<User> Users { get; }
        IList<Competition> Competitions { get; }
        IList<Comment> Comments { get; }
        IList<Event> Events { get; }
        IList<Post> Posts { get; }
        IList<Like> Likes{ get; }
    }
}
