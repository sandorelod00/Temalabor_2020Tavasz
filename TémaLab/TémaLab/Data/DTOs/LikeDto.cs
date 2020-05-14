using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TémaLab.Data.Entities;

namespace TémaLab.Data.DTOs
{
    public class LikeDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int? PostId { get; set; }

        public Post? Post { get; set; }

        public int? CommentId { get; set; }
        public Comment? Comment { get; set; }

        public DateTime date { get; set; }

    }
}
