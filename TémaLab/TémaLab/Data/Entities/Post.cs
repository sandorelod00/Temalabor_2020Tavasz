using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TémaLab.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public DateTime date { get; set; }

        public string Content { get; set; }

        public ICollection<Comment> Comments{ get; set; }
        public ICollection<Like> Likes{ get; set; }

    }
}
