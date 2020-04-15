using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class User
    {
        
        public int Id { get; set; }
        
        public string UserName { get; set; }
        public string Introduction { get; set; }
        public string Email { get; set; }

        public string MTGACode { get; set; }

        public bool Admin { get; set;}

        public ICollection<Post> Posts{ get; set; }
        public ICollection<Friendship> Friendships { get; set; }
        public ICollection<Competition> Competitions{ get; set; }
    }
}
