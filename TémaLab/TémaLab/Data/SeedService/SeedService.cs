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
                Id = 15,
                UserName = "Kovács Péter",
                Introduction="Én vagyok a Peti",
                Email="peti@mail.hu",
                MTGACode="kód",
                Admin = true
            },
            new User { Id = 1, UserName = "Melodie", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et", Email = "justo.sit.amet@Pellentesquetincidunttempus.ca", MTGACode = "B7S 4R4", Admin = true },
            new User { Id = 2, UserName = "Nathaniel", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec", Email = "est.vitae.sodales@tortor.com", MTGACode = "P3N 8J9", Admin = true },
            new User{ Id = 3, UserName = "Maggy", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Email = "et.magnis@estmollisnon.net", MTGACode = "O8R 4J2", Admin = true },
            new User { Id = 4, UserName = "Reagan", Introduction = "Lorem ipsum dolor sit amet,", Email = "Duis.cursus.diam@IncondimentumDonec.org", MTGACode = "J0T 9E2", Admin = false },
            new User{ Id = 5, UserName = "Gil", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Email = "id.erat@eros.com", MTGACode = "X4B 4E1", Admin = true },
            new User{ Id = 6, UserName = "Armand", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing", Email = "turpis@montesnasceturridiculus.edu", MTGACode = "V8B 7U0", Admin = true },
            new User{ Id = 7, UserName = "Bruno", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "sem.eget@sollicitudinamalesuada.org", MTGACode = "V3J 1V4", Admin = true },
            new User{ Id = 8, UserName = "Patrick", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Email = "nec.quam.Curabitur@dictum.org", MTGACode = "I7C 3T4", Admin = true },
            new User{ Id = 9, UserName = "Sasha", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "eget@sociosqu.co.uk", MTGACode = "M7S 7Z3", Admin = false },
            new User{ Id = 10, UserName = "Nerea", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut", Email = "posuere.at@telluseuaugue.edu", MTGACode = "Y9K 8I0", Admin = true },
            new User{ Id = 11, UserName = "Destiny", Introduction = "Lorem ipsum dolor sit amet, consectetuer", Email = "arcu.ac.orci@Nuncac.ca", MTGACode = "I1Q 2P3", Admin = false },
            new User{ Id = 12, UserName = "Megan", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Email = "Sed.diam@enimcommodo.org", MTGACode = "N7S 9B7", Admin = false },
            new User{ Id = 13, UserName = "Dorian", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "nec.tempus.mauris@estac.ca", MTGACode = "Y1Z 8D5", Admin = true },
            new User{ Id = 14, UserName = "Preston", Introduction = "Lorem ipsum", Email = "lobortis.ultrices.Vivamus@feugiat.net", MTGACode = "I6G 4F6", Admin = false },
        }.ToDictionary(a => a.UserName);

        public IDictionary<string, Competition> Competitions { get; } = new[]
        {
            new Competition {Id = 1, Title = "First Competition", Content ="This is our first competition gonna be at", UserId =1 },
            new Competition {Id = 2, Title = "Seccond Competition", Content="This is our seccond competition. created by", UserId=15 }
        }.ToDictionary(c => c.Title);
        public IDictionary<string, Comment> Comments { get; }

        public IDictionary<string, Event> Events { get; }

        public IDictionary<string, Post> Posts { get; } = new[]
        {
            new Post{Id = 1, UserId=2,Content="Helló helló szasztok új vagyok még a weboldalon tudnátok segíteni ? Köszi."},
            new Post{Id = 2, UserId=3, Content="Sziasztok a legjobb Mono Red decket keresem tudnátok segíteni ? köszii..."}
        }.ToDictionary(p => p.Content);

        public IDictionary<string, Like> Likes { get; }

    }
}
