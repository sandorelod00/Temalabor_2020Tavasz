using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;
using TémaLab.Data.SeedInterfaces.SeedService;

namespace TémaLab.Data.SeedService
{
    public class SeedService : ISeedService
    {
        public IList<User> Users { get; }

        public IList<Competition> Competitions { get; }
        
        public IList<Comment> Comments { get; }

        public IList<Event> Events { get; }

        public IList<Post> Posts { get; }

        public IList<Like> Likes { get; }

        public SeedService()
        {
            Users = new List<User>()
                {
                new User()
                {
                    Id = 15,
                    UserName = "Kovács Péter",
                    Introduction = "Én vagyok a Peti",
                    Email = "peti@mail.hu",
                    MTGACode = "kód",
                    Admin = true
                },
            new User { Id = 1, UserName = "Melodie", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec urna et", Email = "justo.sit.amet@Pellentesquetincidunttempus.ca", MTGACode = "B7S 4R4", Admin = true, score = 14567, rank = "silver" },
            new User { Id = 2, UserName = "Nathaniel", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut nec", Email = "est.vitae.sodales@tortor.com", MTGACode = "P3N 8J9", Admin = true, score = 2347 , rank = "gold"},
            new User { Id = 3, UserName = "Maggy", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Email = "et.magnis@estmollisnon.net", MTGACode = "O8R 4J2", Admin = true, score = 678, rank = "plat"},
            new User { Id = 4, UserName = "Reagan", Introduction = "Lorem ipsum dolor sit amet,", Email = "Duis.cursus.diam@IncondimentumDonec.org", MTGACode = "J0T 9E2", Admin = false , score = 8732, rank = "diamond"},
            new User { Id = 5, UserName = "Gil", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Email = "id.erat@eros.com", MTGACode = "X4B 4E1", Admin = true , score = 239874, rank = "silver"},
            new User { Id = 6, UserName = "Armand", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing", Email = "turpis@montesnasceturridiculus.edu", MTGACode = "V8B 7U0", Admin = true ,score = 293, rank = "silver"},
            new User { Id = 7, UserName = "Bruno", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "sem.eget@sollicitudinamalesuada.org", MTGACode = "V3J 1V4", Admin = true , score = 23987, rank = "gold"},
            new User { Id = 8, UserName = "Patrick", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Email = "nec.quam.Curabitur@dictum.org", MTGACode = "I7C 3T4", Admin = true , score = 235, rank = "diamond"},
            new User { Id = 9, UserName = "Sasha", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "eget@sociosqu.co.uk", MTGACode = "M7S 7Z3", Admin = false , score = 89723, rank = "plat"},
            new User { Id = 10, UserName = "Nerea", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam adipiscing lacus. Ut", Email = "posuere.at@telluseuaugue.edu", MTGACode = "Y9K 8I0", Admin = true , score = 2485, rank = "plat"},
            new User { Id = 11, UserName = "Destiny", Introduction = "Lorem ipsum dolor sit amet, consectetuer", Email = "arcu.ac.orci@Nuncac.ca", MTGACode = "I1Q 2P3", Admin = false , score = 23498, rank = "silver"},
            new User { Id = 12, UserName = "Megan", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Email = "Sed.diam@enimcommodo.org", MTGACode = "N7S 9B7", Admin = false , score = 8735, rank = "gold"},
            new User { Id = 13, UserName = "Dorian", Introduction = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed tortor. Integer aliquam", Email = "nec.tempus.mauris@estac.ca", MTGACode = "Y1Z 8D5", Admin = true , score = 32197, rank = "silver"},
            new User { Id = 14, UserName = "Preston", Introduction = "Lorem ipsum", Email = "lobortis.ultrices.Vivamus@feugiat.net", MTGACode = "I6G 4F6", Admin = false }
        };

            Competitions = new List<Competition>()
                {
            new Competition {Id = 1, Title = "First Competition", Content ="This is our first competition gonna be at", UserId =1 },
            new Competition {Id = 2, Title = "Seccond Competition", Content="This is our seccond competition. created by", UserId=15 }
        };

            Events = new List<Event>()
            {
                new Event {Id = 1, UserId  = 7, Title="Sörözünk !", Content="Sziasztok ugy gondolom itt az ideje hogy sörözünk egyett közösen!!!"}
            };

            Posts = new List<Post>()
            {
                new Post{Id = 1, UserId=2,Content="Helló helló szasztok új vagyok még a weboldalon tudnátok segíteni ? Köszi."},
                new Post{Id = 2, UserId=3, Content="Sziasztok a legjobb Mono Red decket keresem tudnátok segíteni ? köszii..."}
            };

            Comments = new List<Comment>()
            {
                new Comment{Id = 1, Content="Szia igen minden kérdésedben nagyon szívesen segítek", UserId=13, PostId=1 },
                new Comment{Id = 2, Content="uhhh.... Az lenne az első kérédésem hogyan kell jétszani ? ", UserId = 2, PostId=1},
                new Comment{Id = 3, Content="ohhh haver én a mono blura esküszök sokkal élvezetesebb azzal a játék....", UserId =11, PostId=2}
            };

            Likes = new List<Like>()
            {
                new Like{ Id =1, PostId=1, UserId=11}
            };

        }

    }
}
